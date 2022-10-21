using Api.Dto;
using Application.Common.Actors.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActorsController : ControllerBase
    {
        public readonly IMediator _mediator;

        public ActorsController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpGet]
        public async Task<IEnumerable<ActorDto.ActorIndex>> GetActors()
        {
            return await _mediator.Send(new GetActorsQuery());
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<ActorDto.ActorDetail>> GetActorDetails([FromRoute] int id)
        {
            var Movies = _mediator.Send(new GetActorsByIdQuery(id)
            );
            return Ok(Movies);

        }






    }
}
