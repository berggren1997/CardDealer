using CardDealer.Contracts.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace CardDealer.Persistence
{
    /// <summary>
    /// Generic repository base, with CRUD-operations
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        private readonly AppDbContext _context;

        public RepositoryBase(AppDbContext context)
        {
            _context = context;
        }

        public IQueryable<T> FindAll(bool trackChanges) =>
            !trackChanges ? _context.Set<T>().AsNoTracking() : _context.Set<T>();

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> condition, bool trackChanges) =>
            !trackChanges ? _context.Set<T>().AsNoTracking().Where(condition) :
            _context.Set<T>().Where(condition);

        public void CreateMany(List<T> entities) => _context.Set<T>().AddRange(entities);

        public void CreateSingle(T entitiy) => _context.Set<T>().Add(entitiy);

    }
}
