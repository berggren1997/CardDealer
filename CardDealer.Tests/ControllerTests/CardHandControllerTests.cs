using CardDealer.Api.Controllers;
using CardDealer.Service.Contracts;
using CardDealer.Shared.Dto;
using CardDealer.Shared.Dto.CardHand;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace CardDealer.Tests.ControllerTests
{
    public class CardHandControllerTests
    {
        private readonly CardHandController _sut;
        private readonly Mock<IServiceManager> _serviceMock = new();
        private List<CardHandDto> _cardHands;

        public CardHandControllerTests()
        {
            _sut = new CardHandController(_serviceMock.Object);
            _cardHands = new List<CardHandDto>();
        }

        [Fact]
        public async Task GetCardHands_ShouldReturnOkResponseWhenDataFound()
        {
            _serviceMock.Setup(x => x.CardHandService.GetCardHands(true))
                .ReturnsAsync(_cardHands);
            
            var response = await _sut.GetCardHands();

            Assert.NotNull(response);
            _serviceMock.Verify(x => x.CardHandService.GetCardHands(true), Times.Once);
            Assert.IsType<OkObjectResult>(response as OkObjectResult);
        }

        [Fact]
        public async Task GetCardHands_ShouldReturnNotFoundResponseWhenDataNotFound()
        {
            _serviceMock.Setup(x => x.CardHandService.GetCardHands(true))
                .ReturnsAsync((List<CardHandDto>) null);

            var response = await _sut.GetCardHands();

            Assert.NotNull(response);
            _serviceMock.Verify(x => x.CardHandService.GetCardHands(true), Times.Once);
            Assert.IsType<NotFoundObjectResult>(response as NotFoundObjectResult);
        }

        //[Fact]
        //public async Task CreateCardHand_ShouldReturn201Created()
        //{
        //    var cardHand = new CardHandDto()
        //    {
        //        HandId = Guid.NewGuid(),
        //        CardHand = new List<CardDto>()
        //    };

        //    _serviceMock.Setup(x => x.CardHandService.CreateCardHand(cardHand))
        //        .ReturnsAsync(true);

        //    int statusCodeCreated = 201;

        //    //_serviceMock.Verify(x => x.CardHandService.CreateCardHand(cardHand), Times.Once);
        //}
    }
}
