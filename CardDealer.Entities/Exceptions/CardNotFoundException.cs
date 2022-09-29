namespace CardDealer.Entities.Exceptions
{
    public class CardNotFoundException : NotFoundException
    {
        public CardNotFoundException() : base("Could not retrieve cards from database")
        { }
    }
}
