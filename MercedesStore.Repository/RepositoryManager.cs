using MercedesStore.Contract;
using System.Net.Http.Headers;

namespace MercedesStore.Repository
{
    public class RepositoryManager : IRepositoryManager
    {


        private readonly Lazy<IAutoRepository> _autoRepository;
        private readonly Lazy<ICategoryRepository> _categoryRepository;
        private readonly Lazy<IReviewRepository> _reviewRepository;
        private readonly MercedesDbContext _mercedesDbContext;
        public RepositoryManager(MercedesDbContext context)
        {
            _mercedesDbContext = context;
            _autoRepository = new Lazy<IAutoRepository>(()=>new AutoRepository(context));
            _categoryRepository = new Lazy<ICategoryRepository>(()=>new CategoryRepository(context));
            _reviewRepository = new Lazy<IReviewRepository>(()=>new ReviewRepository(context));
        }


        public IAutoRepository AutoRepository => _autoRepository.Value;

        public ICategoryRepository CategoryRepository => _categoryRepository.Value;

        public IReviewRepository ReviewRepository => _reviewRepository.Value;

        public async Task SaveAsync()
        {
            await _mercedesDbContext.SaveChangesAsync();
        }
    }
}
