using CardDealer.Entities.Models;

namespace CardDealer.Contracts.Interfaces
{
    public interface ICardHandRepository
    {
        Task<IEnumerable<Hand>> GetCardHands(bool trackChanges);
        void CreateCardHand(Hand cardHand);
    }
}
