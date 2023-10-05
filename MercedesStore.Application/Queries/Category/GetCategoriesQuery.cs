using MediatR;
using MercedesStore.Shared.DTO;

namespace MercedesStore.Application.Queries.Category
{
    public sealed record GetCategoriesQuery(bool TrackChanges): IRequest<IEnumerable<CategoryDTO>>
    {
    }
}
