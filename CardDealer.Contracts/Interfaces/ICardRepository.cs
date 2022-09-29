using CardDealer.Entities.Models;

namespace CardDealer.Contracts.Interfaces
{
    public interface ICardRepository
    {
        Task<IEnumerable<Card>> GetDeckOfCardsAsync(bool trackChanges);
        void CreateCards(List<Card> cards);
    }
}
