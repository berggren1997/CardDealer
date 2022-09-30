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
            
            if(cardHands == null || !cardHands.Any())
                return NotFound("No data found in database");

            return Ok(cardHands);
        }

        [HttpGet("{id}", Name = "GetCardHand")]
        public async Task<IActionResult> GetCardHand(Guid id)
        {
            var cardHand = await _service.CardHandService.GetCardHand(id, trackChanges: true);
            
            if (cardHand == null)
                return NotFound("No card was found");

            return Ok(cardHand);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCardHand([FromBody] CardHandDto newCardHand)
        {
            var cardHand = await _service.CardHandService.CreateCardHand(newCardHand);

            if (cardHand == null) 
                return BadRequest("Something went wrong when sending your request");

            return CreatedAtRoute("GetCardHand", new { id = cardHand.HandId }, cardHand);
        }
    }
}
