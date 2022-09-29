using CardDealer.Contracts.Interfaces;
using CardDealer.Entities.Exceptions;
using CardDealer.Entities.Models;
using CardDealer.Service.Contracts.Cards;
using CardDealer.Shared.Dto;

namespace CardDealer.Service.Cards
{
    public class CardService : ICardService
    {
        private readonly IRepositoryManager _repositoryManager;

        public CardService(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }

        /// <summary>
        /// requests a deck of cards from database, and maps the result into dto
        /// </summary>
        /// <param name="trackChanges"></param>
        /// <returns>deck of cards</returns>
        public async Task<List<CardDto>> GetDeckOfCards(bool trackChanges)
        {
            IEnumerable<Card> cardEntities = await _repositoryManager
                .CardRepository.GetDeckOfCardsAsync(trackChanges);

            if (cardEntities == null) 
                throw new CardNotFoundException();

            return MapCardsToDto(cardEntities);
        }

        /// <summary>
        /// Custom mapping method to map from entity -> dto
        /// </summary>
        /// <param name="cardsToMapFrom"></param>
        /// <returns></returns>
        public List<CardDto> MapCardsToDto(IEnumerable<Card> cardsToMapFrom)
        {
            if (cardsToMapFrom == null)
            {
                return new List<CardDto>();
            }
            
            return cardsToMapFrom.Select(card => new CardDto
            {
                Id = card.Id,
                Suit = card.Suit,
                Value = card.Value,
            }).ToList();
        }
    }
}
