using MediatR;
using MercedesStore.Entities.Models;
using MercedesStore.Shared.DTO;

namespace MercedesStore.Application.Queries.Auto
{
    public sealed record GetAutosQuery(int CategoryId, bool TrackChanges): IRequest<IEnumerable<AutoDTO>>;
    
}
