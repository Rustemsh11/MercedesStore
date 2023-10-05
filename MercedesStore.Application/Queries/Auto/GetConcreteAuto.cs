using MediatR;
using MercedesStore.Shared.DTO;

namespace MercedesStore.Application.Queries.Auto
{
    public record GetConcreteAuto(int CategoryId, int AutoId, bool TrackChanges): IRequest<AutoDTO>;
    
}
