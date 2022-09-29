namespace CardDealer.Shared.Dto
{
    public class CardDto
    {
        public Guid Id { get; set; }
        public string Suit { get; set; } = string.Empty;
        public string Value { get; set; } = string.Empty;
    }
}
