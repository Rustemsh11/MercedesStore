using AutoMapper;
using MediatR;
using MercedesStore.Application.Queries.Category;
using MercedesStore.Contract;
using MercedesStore.Shared.DTO;

namespace MercedesStore.Application.Handlers.Category
{
    public sealed class GetCategoriesHandler : IRequestHandler<GetCategoriesQuery, IEnumerable<CategoryDTO>>
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;

        public GetCategoriesHandler(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        public async Task<IEnumerable<CategoryDTO>> Handle(GetCategoriesQuery request, CancellationToken cancellationToken)
        {
            var categories = await _repositoryManager.CategoryRepository.GetAllCategoriesAsync(request.TrackChanges);

            var categoriesDTO = _mapper.Map<IEnumerable<CategoryDTO>>(categories);
            
            return categoriesDTO;
        }
    }
}
