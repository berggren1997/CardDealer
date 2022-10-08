using CardDealer.Contracts.Interfaces;
using CardDealer.Service.Cards;
using CardDealer.Service.Contracts;
using CardDealer.Service.Contracts.Cards;

namespace CardDealer.Service
{
    /// <summary>
    /// this class is used to lazy load our services
    /// </summary>
    public class ServiceManager : IServiceManager
    {
        private readonly Lazy<ICardService> _cardService;
        private readonly Lazy<ICardHandService> _cardHandService;

        public ServiceManager(IRepositoryManager repositoryManager)
        {
            _cardService = new Lazy<ICardService>(() =>
                new CardService(repositoryManager));
            _cardHandService = new Lazy<ICardHandService>(() =>
                new CardHandService(repositoryManager));
        }

        public ICardService CardService => _cardService.Value;
        public ICardHandService CardHandService => _cardHandService.Value;
    }
}
