using MediatR;
using MercedesStore.Application.Queries.Category;
using Microsoft.AspNetCore.Mvc;

namespace MercedesStore.Presentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [ApiExplorerSettings(GroupName = "v1")]
    public class CategoryController : ControllerBase
    {
        private readonly ISender _sender;

        public CategoryController(ISender sender)
        {
            _sender = sender;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCategories()
        {
            var categories = await _sender.Send(new GetCategoriesQuery(TrackChanges: false));
            
            return Ok(categories);
        }
    }
}
