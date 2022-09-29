using CardDealer.Shared.Dto;

namespace CardDealer.Service.Contracts.Cards
{
    public interface ICardService
    {
        Task<List<CardDto>> GetDeckOfCards(bool trackChanges);
    }
}
