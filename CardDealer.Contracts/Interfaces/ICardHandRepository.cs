using CardDealer.Entities.Models;

namespace CardDealer.Contracts.Interfaces
{
    public interface ICardHandRepository
    {
        Task<IEnumerable<Hand>> GetCardHands(bool trackChanges);
        Task<Hand> GetCardHand(Guid id, bool trackChanges);
        void CreateCardHand(Hand cardHand);
    }
}
