using MercedesStore.Contract;
using MercedesStore.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace MercedesStore.Repository
{
    public class CategoryRepository : RepositoryBase<Category>, ICategoryRepository
    {
        public CategoryRepository(MercedesDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Category>> GetAllCategoriesAsync(bool trackChanges )
        {
            return await FindAll(trackChanges).OrderBy(c=>c.Name).ToListAsync();
        }

        public async Task<Category> GetCategoryAsync(int id, bool trackChanges)
        {
            return await FindByCondition(c => c.CategoryId.Equals(id), trackChanges).SingleOrDefaultAsync();
        }
    }
}
