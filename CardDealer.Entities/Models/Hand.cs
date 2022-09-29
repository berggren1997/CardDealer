namespace CardDealer.Entities.Models
{
    public class Hand
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }

        // relationships
        //public List<Card> Cards { get; set; } = new();
        public List<CardHand> CardHands { get; set; } = new();
    }
}
