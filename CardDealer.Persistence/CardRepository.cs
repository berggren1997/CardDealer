using CardDealer.Contracts.Interfaces;
using CardDealer.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace CardDealer.Persistence
{
    public class CardRepository : RepositoryBase<Card>, ICardRepository
    {
        public CardRepository(AppDbContext context) : base(context)
        { }

        public async Task<IEnumerable<Card>> GetCardHistory(bool trackChanges) =>
            await FindAll(trackChanges)
            .OrderBy(x => x.Suit)
            .ToListAsync();

        public async Task<IEnumerable<Card>> GetDeckOfCardsAsync(bool trackChanges) =>
            await FindAll(trackChanges)
            .OrderBy(x => x.Value)
            .ToListAsync();

        public void CreateCards(List<Card> cards) =>
            CreateMany(cards);

    }
}
