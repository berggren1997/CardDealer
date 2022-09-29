using CardDealer.Contracts.Interfaces;
using CardDealer.Entities.Exceptions;
using CardDealer.Entities.Models;
using CardDealer.Service.Cards;
using Moq;

namespace CardDealer.Tests.ServiceTests
{
    public class CardHandServiceTests
    {
        private readonly CardHandService _sut;
        private readonly Mock<IRepositoryManager> _repoMock = new();
        private IEnumerable<Hand> _cardHands;
        
        public CardHandServiceTests()
        {
            _sut = new CardHandService(_repoMock.Object);
            
            _cardHands = new List<Hand>()
            {
                new Hand()
                {
                    Id = Guid.NewGuid(),
                    CardHands = new List<CardHand>()
                },
                new Hand()
                {
                    Id = Guid.NewGuid(),
                    CardHands = new List<CardHand>()
                },
                new Hand()
                {
                    Id = Guid.NewGuid(),
                    CardHands = new List<CardHand>()
                }
            };
        }
        
        [Fact]
        public async Task GetCardHands_Valid_ShouldReturnListOfExpectedLength()
        {
            int expectedLength = 3;
            
            _repoMock.Setup(x => x.CardHandRepository.GetCardHands(true))
                .ReturnsAsync(_cardHands);

            var cardHands = await _sut.GetCardHands(true);

            Assert.Equal(expectedLength, cardHands.Count());
        }

        [Fact]
        public async Task GetCardHands_Invalid_ShouldThrowException()
        {
            _repoMock.Setup(x => x.CardHandRepository.GetCardHands(true))
                .ReturnsAsync((IEnumerable<Hand>)null);
            
            await Assert.ThrowsAsync<CardHandsNotFoundException>(() => _sut.GetCardHands(true));
        }

        [Fact]
        public void MapToDto_ShouldReturnListOfSameLength()
        {
            int expectedLength = 3;

            var cardDtoList = _sut.MapToDto(_cardHands);

            Assert.Equal(expectedLength, cardDtoList.Count);
        }
    }
}
