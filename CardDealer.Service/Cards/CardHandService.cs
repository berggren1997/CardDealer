using CardDealer.Contracts.Interfaces;
using CardDealer.Entities.Exceptions;
using CardDealer.Entities.Models;
using CardDealer.Service.Contracts.Cards;
using CardDealer.Shared.Dto;
using CardDealer.Shared.Dto.CardHand;
using System.Net.Http.Headers;
using System.Reflection.Metadata;

namespace CardDealer.Service.Cards
{
    public class CardHandService : ICardHandService
    {
        private readonly IRepositoryManager _repositoryManger;

        public CardHandService(IRepositoryManager repositoryManger)
        {
            _repositoryManger = repositoryManger;
        }

        /// <summary>
        /// Saves card hand to database
        /// </summary>
        /// <param name="cardHand"></param>
        /// <returns></returns>
        public async Task<CardHandDto> CreateCardHand(CardHandDto cardHand)
        {
            Guid randomCardHandId = Guid.NewGuid();

            Hand cardHandEntity = new()
            {
                Id = randomCardHandId,
                CreatedAt = DateTime.Now,
                CardHands = cardHand.CardHand.Select(card => new CardHand
                {
                    CardId = card.Id,
                    HandId = randomCardHandId
                }).ToList()
            };

            _repositoryManger.CardHandRepository.CreateCardHand(cardHandEntity);
            var result = await _repositoryManger.SaveAsync();

            if (result > 0)
            {
                return new CardHandDto
                {
                    HandId = cardHandEntity.Id,
                    CreatedAt = cardHandEntity.CreatedAt,
                    CardHand = cardHandEntity.CardHands.Select(x => new CardDto
                    {
                        Id = x.CardId,
                        Suit = x.Card.Suit,
                        Value = x.Card.Value
                    }).ToList()

                };
            }
            else
            {
                throw new CardHandBadRequestException();
            }

        }

        public async Task<CardHandDto> GetCardHand(Guid id, bool trackChanges)
        {
            var cardHandEntity = await _repositoryManger.CardHandRepository.GetCardHand(id, trackChanges);

            if (cardHandEntity == null)
                throw new CardNotFoundException();

            var cardToReturn = new CardHandDto
            {
                HandId = cardHandEntity.Id,
                CreatedAt = cardHandEntity.CreatedAt,
                CardHand = cardHandEntity.CardHands.Select(x => new CardDto
                {
                    Id = x.CardId,
                    Suit = x.Card.Suit,
                    Value = x.Card.Value
                }).ToList()
            };

            return cardToReturn;
        }

        /// <summary>
        /// requests saved card hands from database, and maps it to dto
        /// </summary>
        /// <param name="trackChanges"></param>
        /// <returns>list of card hand dto's</returns>
        /// <exception cref="CardHandsNotFoundException"></exception>
        public async Task<List<CardHandDto>> GetCardHands(bool trackChanges)
        {
            IEnumerable<Hand> cardHandEntities = await _repositoryManger.CardHandRepository
                .GetCardHands(trackChanges);

            if (cardHandEntities == null)
                throw new CardHandsNotFoundException();

            List<CardHandDto> cardHandsToReturn = MapToDto(cardHandEntities);

            return cardHandsToReturn;
        }

        public List<CardHandDto> MapToDto(IEnumerable<Hand> cardHandEntities)
        {
            return cardHandEntities.Select(h =>
            new CardHandDto
            {
                HandId = h.Id,
                CreatedAt = h.CreatedAt,
                CardHand = h.CardHands.Select(ch => new CardDto
                {
                    Id = ch.CardId,
                    Value = ch.Card.Value,
                    Suit = ch.Card.Suit
                }).ToList()
            }).ToList();
        }
    }
}
