using MercedesStore.Entities.Models;

namespace MercedesStore.Shared.DTO
{
    public record AutoDTO(string Name, string Description, decimal Price, List<ReviewDTO> Reviews);
    
}
