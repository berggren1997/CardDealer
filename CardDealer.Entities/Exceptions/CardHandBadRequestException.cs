namespace CardDealer.Entities.Exceptions
{
    public class CardHandBadRequestException : BadRequestException
    {
        public CardHandBadRequestException() : base("Bad card hand request from client")
        { }
    }
}
