using CardDealer.Contracts.Interfaces;
using CardDealer.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace CardDealer.Persistence
{
    /// <summary>
    /// This repository is used to manage CRUD operations accoridng to card hands
    /// </summary>
    public class CardHandRepository : RepositoryBase<Hand>, ICardHandRepository
    {
        public CardHandRepository(AppDbContext context) : base(context)
        { }

        /// <summary>
        /// Requests database for all card hands, and orders them by date
        /// </summary>
        /// <param name="trackChanges"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Hand>> GetCardHands(bool trackChanges) =>
            await FindAll(trackChanges)
            .Include(card => card.CardHands)
            .ThenInclude(x => x.Card)
            .OrderBy(x => x.CreatedAt)
            .ToListAsync();

        /// <summary>
        /// Creates a cardhand
        /// </summary>
        /// <param name="cardHand"></param>
        public void CreateCardHand(Hand cardHand) =>
            CreateSingle(cardHand);

        /// <summary>
        /// Requests database for a single hand that matches given id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="trackChanges"></param>
        /// <returns></returns>
        public async Task<Hand> GetCardHand(Guid id, bool trackChanges) =>
            await FindByCondition(x => x.Id == id, trackChanges)
            .Include(card => card.CardHands)
            .ThenInclude(ch => ch.Card)
            .OrderBy(d => d.CreatedAt)
            .FirstOrDefaultAsync();
    }
}
