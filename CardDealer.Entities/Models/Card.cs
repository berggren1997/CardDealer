namespace CardDealer.Entities.Models
{
    public class Card
    {
        public Guid Id { get; set; }
        public string Suit { get; set; }
        public string Value { get; set; }

        //relationships
        public List<CardHand> CardHands { get; set; } = new();
    }
}
