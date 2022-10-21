using Api.Dto;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActorsController : ControllerBase
    {
        public IMediator _mediator;

        public ActorsController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<ActorDto.Index>>> GetActors()
        {
            var Movies = _mediator.Send(new
            {

            });
            return Ok();
        }
    }
}
