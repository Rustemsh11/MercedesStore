using MercedesStore.Contract;
using MercedesStore.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace MercedesStore.Repository
{
    public class AutoRepository : RepositoryBase<Auto>, IAutoRepository
    {
        public AutoRepository(MercedesDbContext mercedesDbContext):base(mercedesDbContext) 
        {
            
        }

        public async Task<IEnumerable<Auto>> GetAllAutoAsync(int categoryId, bool trackChanges)
        {
            return await FindByCondition(c => c.CategoryId.Equals(categoryId), trackChanges).Include(c=>c.Reviews).ToListAsync();
        }

        public async Task<Auto> GetAutoAsync(int categoryId, int autoId, bool trackChanges)
        {
            return await FindByCondition(c => c.CategoryId.Equals(categoryId) && c.AutoId.Equals(autoId), trackChanges).SingleOrDefaultAsync();
        }
    }
}
