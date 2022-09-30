using CardDealer.Shared.Dto.CardHand;

namespace CardDealer.Service.Contracts.Cards
{
    public interface ICardHandService
    {
        Task<List<CardHandDto>> GetCardHands(bool trackChanges);
        Task<CardHandDto> GetCardHand(Guid id, bool trackChanges);
        Task<CardHandDto> CreateCardHand(CardHandDto cardHand);
    }
}
