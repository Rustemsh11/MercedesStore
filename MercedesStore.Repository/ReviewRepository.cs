using MercedesStore.Contract;
using MercedesStore.Entities.Models;

namespace MercedesStore.Repository
{
    public class ReviewRepository : RepositoryBase<Review>, IReviewRepository
    {
        public ReviewRepository(MercedesDbContext context) : base(context)
        {
        }
    }
}
