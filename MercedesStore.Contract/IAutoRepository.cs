using MercedesStore.Entities.Models;

namespace MercedesStore.Contract
{
    public interface IAutoRepository
    {
        Task<IEnumerable<Auto>> GetAllAutoAsync(int categoryId, bool trackChanges);
        Task<Auto> GetAutoAsync(int categoryId, int autoId, bool trackChanges);
        
    }
}
