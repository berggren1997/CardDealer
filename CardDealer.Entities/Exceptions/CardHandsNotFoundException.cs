namespace CardDealer.Entities.Exceptions
{
    public class CardHandsNotFoundException : NotFoundException
    {
        public CardHandsNotFoundException() : base("Could not retrieve card hands from database")
        { }
    }
}
