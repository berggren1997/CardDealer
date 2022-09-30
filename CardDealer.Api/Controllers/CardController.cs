using CardDealer.Service.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace CardDealer.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CardController : ControllerBase
    {
        private readonly IServiceManager _service;
        
        public CardController(IServiceManager service)
        {
            _service = service;
        }
        
        [HttpGet]
        public async Task<IActionResult> GetDeckOfCards()
        {
            var cards = await _service.CardService.GetDeckOfCards(trackChanges: false);

            return cards != null ? Ok(cards) : NotFound("No cards found");
            //return Ok(cards);
        }
    }
}
