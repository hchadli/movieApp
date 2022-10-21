using System.Diagnostics.CodeAnalysis;
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
        public async Task<IEnumerable<ActorDto.Index>> GetActors()
        {
            return await _mediator.Send(new GetActorsQuery());
        }
    }
}
