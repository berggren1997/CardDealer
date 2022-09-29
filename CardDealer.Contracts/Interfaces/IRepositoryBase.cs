namespace CardDealer.Contracts.Interfaces
{
    public interface IRepositoryBase<T>
    {
        IQueryable<T> FindAll(bool trackChanges);
        void CreateMany(List<T> entities);
        void CreateSingle(T entitiy);
    }
}
