using CardDealer.Service.Contracts;
using CardDealer.Shared.Dto.CardHand;
using Microsoft.AspNetCore.Mvc;

namespace CardDealer.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CardHandController : ControllerBase
    {
        private readonly IServiceManager _service;

        public CardHandController(IServiceManager service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetCardHands()
        {
            // trackchanges true due to lazy loading error otherwise
            var cardHands = await _service.CardHandService
                .GetCardHands(trackChanges: true);

            return Ok(cardHands);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCardHand([FromBody] CardHandDto cardHand)
        {
            bool cardHandSuccess = await _service.CardHandService.CreateCardHand(cardHand);

            if (!cardHandSuccess) return BadRequest("Something went wrong with your request");

            //TODO: Return createdatroute instead, so create a getbyid cardhand method
            return StatusCode(201);
        }
    }
}
