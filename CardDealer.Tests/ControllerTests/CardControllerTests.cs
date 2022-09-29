using CardDealer.Api.Controllers;
using CardDealer.Service.Contracts;
using CardDealer.Shared.Dto;
using Moq;

namespace CardDealer.Tests.ControllerTests
{
    public class CardControllerTests
    {
        private readonly CardController _sut;
        private readonly Mock<IServiceManager> _serviceMock = new();
        private List<CardDto> _cards;

        public CardControllerTests()
        {
            _sut = new CardController(_serviceMock.Object);
            
            _cards = new()
            {
                new CardDto
                {
                    Id = Guid.NewGuid(),
                    Suit = "Spades",
                    Value = "Ace"
                },
                new CardDto
                {
                    Id = Guid.NewGuid(),
                    Suit = "Spades",
                    Value = "King"
                },
                new CardDto
                {
                    Id = Guid.NewGuid(),
                    Suit = "Spades",
                    Value = "Queen"
                }
            };
        }
    }
}
