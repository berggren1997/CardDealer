using CardDealer.Contracts.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CardDealer.Persistence
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        private readonly AppDbContext _context;

        public RepositoryBase(AppDbContext context)
        {
            _context = context;
        }

        public IQueryable<T> FindAll(bool trackChanges) =>
            !trackChanges ? _context.Set<T>().AsNoTracking() : _context.Set<T>();

        public void CreateMany(List<T> entities) => _context.Set<T>().AddRange(entities);

        public void CreateSingle(T entitiy) => _context.Set<T>().Add(entitiy);

    }
}
