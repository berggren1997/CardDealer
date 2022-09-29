using CardDealer.Service.Contracts.Cards;

namespace CardDealer.Service.Contracts
{
    public interface IServiceManager
    {
        ICardService CardService { get; }
        ICardHandService CardHandService { get; }
    }
}
