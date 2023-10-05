using MediatR;
using MercedesStore.Application.Queries.Auto;
using Microsoft.AspNetCore.Mvc;

namespace MercedesStore.Presentation.Controllers
{
    [ApiController]
    [Route("api/category/{id:int}/[controller]")]
    [ApiExplorerSettings(GroupName = "v1")]
    public class AutoController: ControllerBase
    {
        private readonly ISender _sender;

        public AutoController(ISender sender)
        {
            _sender = sender;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAuto(int id)
        {
            var autos = await _sender.Send(new GetAutosQuery(id, TrackChanges: false));
            return Ok(autos);
        }

        [HttpGet("{autoId}:int")]
        public async Task<IActionResult> GetAuto(int id, int autoId)
        {
            var autos = await _sender.Send(new GetConcreteAuto(id, autoId, TrackChanges: false));

            return Ok(autos);
        }
    }
}
