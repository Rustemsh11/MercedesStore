using MercedesStore.Entities.Models;

namespace MercedesStore.Contract
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetAllCategoriesAsync(bool trackChanges);
        Task<Category> GetCategoryAsync(int id,bool trackChanges );
    }
}
