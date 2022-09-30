using CardDealer.Api.Controllers;
using CardDealer.Service.Contracts;
using CardDealer.Shared.Dto;
using Microsoft.AspNetCore.Mvc;
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

        [Fact]
        public async Task GetDeckOfCards_ShouldReturnOkResponseWhenDataFound()
        {
            // Arrange
            _serviceMock.Setup(x => x.CardService.GetDeckOfCards(false))
                .ReturnsAsync(_cards);

            // Act
            var result = await _sut.GetDeckOfCards();

            // Assert
            Assert.NotNull(result);
            _serviceMock.Verify(x => x.CardService.GetDeckOfCards(false), Times.Once);
            Assert.IsType<OkObjectResult>(result as OkObjectResult);
        }

        [Fact]
        public async Task GetDeckOfCards_ShouldReturnNotFoundWhenNoDataFound()
        {
            // Arrange
            _serviceMock.Setup(x => x.CardService.GetDeckOfCards(false))
                .ReturnsAsync((List<CardDto>)null);

            // Act
            var result = await _sut.GetDeckOfCards();

            // Assert
            Assert.NotNull(result);
            _serviceMock.Verify(x => x.CardService.GetDeckOfCards(false), Times.Once);
            Assert.IsType<NotFoundObjectResult>(result as NotFoundObjectResult);
        }
    }
}
