using CardDealer.Shared.Dto.CardHand;

namespace CardDealer.Service.Contracts.Cards
{
    public interface ICardHandService
    {
        Task<List<CardHandDto>> GetCardHands(bool trackChanges);
        Task<bool> CreateCardHand(CardHandDto cardHand);
    }
}
