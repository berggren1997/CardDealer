using Moq;
using CardDealer.Contracts.Interfaces;
using CardDealer.Service.Cards;
using CardDealer.Entities.Models;
using CardDealer.Entities.Exceptions;

namespace CardDealer.Tests.ServiceTests
{
    public class CardServiceTests
    {
        private readonly CardService _sut;
        private readonly Mock<IRepositoryManager> _repoMock = new();
        private IEnumerable<Card> _cards;

        public CardServiceTests()
        {
            _sut = new CardService(_repoMock.Object);
            _cards = new List<Card>
            {
                new Card
                {
                    Suit = "Hearts",
                    Value = "Ace",
                },
                new Card
                {
                    Suit = "Hearts",
                    Value = "King",
                },
                new Card
                {
                    Suit = "Hearts",
                    Value = "Queen",
                }
            };
        }

        [Fact]
        public async Task GetDeckOfCards_Valid_ShouldReturnListOfExpectedLength()
        {
            // Arrange
            int expectedLength = 3;

            _repoMock.Setup(x => x.CardRepository.GetDeckOfCardsAsync(false))
                .ReturnsAsync(_cards);

            // Act
            var cardList = await _sut.GetDeckOfCards(false);

            // Assert
            Assert.Equal(expectedLength, cardList.Count);
        }

        [Fact]
        public async Task GetDeckOfCards_Invalid_ShouldThrowException()
        {
            _repoMock.Setup(x => x.CardRepository.GetDeckOfCardsAsync(false))
                .ReturnsAsync((IEnumerable<Card>) null);

            await Assert.ThrowsAsync<CardNotFoundException>(() => _sut.GetDeckOfCards(false));
        }

        [Fact]
        public void MapCardsToDto_Valid_ShouldReturnListWithSameLength()
        {
            // Arrange
            int expectedLength = 3;
            
            // Act
            var cardDtoList = _sut.MapCardsToDto(_cards);

            // Assert
            Assert.True(cardDtoList.Any());
            Assert.NotNull(cardDtoList);
            Assert.Equal(expectedLength, cardDtoList.Count);
        }

        [Fact]
        public void MapCardsToDto_Invalid_ShouldReturnEmptyList()
        {
            var cardDtoList = _sut.MapCardsToDto(null);

            Assert.True(cardDtoList.Count == 0);
        }
    }
}
