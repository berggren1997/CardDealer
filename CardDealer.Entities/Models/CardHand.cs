namespace CardDealer.Entities.Models
{
    public class CardHand
    {
        public Guid HandId { get; set; }
        public Hand? Hand { get; set; }
        public Guid CardId { get; set; }
        public Card? Card { get; set; }
    }
}
