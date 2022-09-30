using System.Linq.Expressions;

namespace CardDealer.Contracts.Interfaces
{
    public interface IRepositoryBase<T>
    {
        IQueryable<T> FindAll(bool trackChanges);
        IQueryable<T> FindByCondition(Expression<Func<T, bool>> condition, bool trackChanges);
        void CreateMany(List<T> entities);
        void CreateSingle(T entitiy);
    }
}
