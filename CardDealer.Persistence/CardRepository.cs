using CardDealer.Contracts.Interfaces;
using CardDealer.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace CardDealer.Persistence
{
    /// <summary>
    /// This class manages the deck of cards
    /// </summary>
    public class CardRepository : RepositoryBase<Card>, ICardRepository
    {
        public CardRepository(AppDbContext context) : base(context)
        { }

        public async Task<IEnumerable<Card>> GetCardHistory(bool trackChanges) =>
            await FindAll(trackChanges)
            .OrderBy(x => x.Suit)
            .ToListAsync();

        /// <summary>
        /// this method requests the database for a standard deck of 52 cards
        /// </summary>
        /// <param name="trackChanges"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Card>> GetDeckOfCardsAsync(bool trackChanges) =>
            await FindAll(trackChanges)
            .OrderBy(x => x.Value)
            .ToListAsync();

        public void CreateCards(List<Card> cards) =>
            CreateMany(cards);

    }
}
