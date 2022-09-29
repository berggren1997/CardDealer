namespace CardDealer.Shared.Dto.CardHand
{
    public class CardHandDto
    {
        public Guid HandId { get; set; }
        public DateTime CreatedAt { get; set; }
        public List<CardDto> CardHand { get; set; } = new List<CardDto>();

    }
}
