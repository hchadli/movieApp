using Application.Common.TvShows.Commands;
using Application.Common.TvShows.Dtos;
using Application.Common.TvShows.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TvShowsController : ControllerBase
    {
        public readonly IMediator _mediator;

        public TvShowsController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpGet]
        public async Task<IEnumerable<TvShowDto.TvShowIndex>> GetTvShows()
        {
            return await _mediator.Send(new GetTvShowsQuery());
        }

        [HttpGet("{id:int}")]
        public async Task<TvShowDto.TvShowDetail> GetTvShowById([FromRoute] int id)
        {
            return await _mediator.Send(new GetTvShowByIdQuery(id));
        }

        [HttpPost]
        public async Task<ActionResult> Create([FromBody] CreateTvShowCommand command)
        {
            await _mediator.Send(command);
            return Ok();
        }
    }
}
