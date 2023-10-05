using AutoMapper;
using MediatR;
using MercedesStore.Application.Queries.Auto;
using MercedesStore.Contract;
using MercedesStore.Shared.DTO;

namespace MercedesStore.Application.Handlers.Auto
{
    public class GetConcreteAutoHandler : IRequestHandler<GetConcreteAuto, AutoDTO>
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;


        public GetConcreteAutoHandler(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        public async Task<AutoDTO> Handle(GetConcreteAuto request, CancellationToken cancellationToken)
        {
            var category = await _repositoryManager.CategoryRepository.GetCategoryAsync(request.CategoryId, request.TrackChanges);
            if(category is null)
            {
                throw new ArgumentNullException();
            }

            var auto = await _repositoryManager.AutoRepository.GetAutoAsync(request.CategoryId, request.AutoId, request.TrackChanges);
            var autoDto = _mapper.Map<AutoDTO>(auto);
            return autoDto;
        }
    }
}
