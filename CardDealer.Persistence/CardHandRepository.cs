using CardDealer.Contracts.Interfaces;
using CardDealer.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace CardDealer.Persistence
{
    public class CardHandRepository : RepositoryBase<Hand>, ICardHandRepository
    {
        public CardHandRepository(AppDbContext context) : base(context)
        { }

        public async Task<IEnumerable<Hand>> GetCardHands(bool trackChanges) =>
            await FindAll(trackChanges)
            .Include(card => card.CardHands)
            .ThenInclude(x => x.Card)
            .OrderBy(x => x.CreatedAt)
            .ToListAsync();

        public void CreateCardHand(Hand cardHand) =>
            CreateSingle(cardHand);
    }
}
