namespace CardDealer.Contracts.Interfaces
{
    public interface IRepositoryManager
    {
        ICardRepository CardRepository { get; }
        ICardHandRepository CardHandRepository { get; }
        Task<int> SaveAsync();
    }
}
