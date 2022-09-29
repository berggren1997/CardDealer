using CardDealer.Contracts.Interfaces;

namespace CardDealer.Persistence
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly AppDbContext _context;
        private readonly Lazy<ICardRepository> _cardRepository;
        private readonly Lazy<ICardHandRepository> _cardHandRepository;

        public RepositoryManager(AppDbContext context)
        {
            _context = context;
            _cardRepository = new Lazy<ICardRepository>(() =>
                new CardRepository(context));
            _cardHandRepository = new Lazy<ICardHandRepository>(() =>
                new CardHandRepository(context));
        }

        public ICardRepository CardRepository => _cardRepository.Value;
        public ICardHandRepository CardHandRepository => _cardHandRepository.Value;
        public async Task<int> SaveAsync() => await _context.SaveChangesAsync();
    }
}
