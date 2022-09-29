using CardDealer.Shared.Dto;
using CardDealer.Shared.Dto.CardHand;

namespace CardDealer.Client.Services.HttpService
{
    public interface ICardService
    {
        Task<Stack<CardDto>> GetDeckOfCards();
        Task<bool> SaveCardHand(CardHandDto cardHandDto);
        Task<List<CardHandDto>> GetCardHands();
    }
}
