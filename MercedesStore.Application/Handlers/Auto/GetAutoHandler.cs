using AutoMapper;
using MediatR;
using MercedesStore.Application.Queries.Auto;
using MercedesStore.Contract;
using MercedesStore.Shared.DTO;

namespace MercedesStore.Application.Handlers.Auto
{
    public class GetAutoHandler : IRequestHandler<GetAutosQuery, IEnumerable<AutoDTO>>
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;

        public GetAutoHandler(IMapper mapper, IRepositoryManager repositoryManager)
        {
            _mapper = mapper;
            _repositoryManager = repositoryManager;
        }

        public async Task<IEnumerable<AutoDTO>> Handle(GetAutosQuery request, CancellationToken cancellationToken)
        {
            var category = await _repositoryManager.CategoryRepository.GetCategoryAsync(request.CategoryId, request.TrackChanges);

            if(category is null)
            {
                throw new ArgumentNullException();
            }

            var autos = await _repositoryManager.AutoRepository.GetAllAutoAsync(request.CategoryId, request.TrackChanges);
            var autoDto = _mapper.Map<IEnumerable<AutoDTO>>(autos);
            return autoDto;
        }
    }
}
