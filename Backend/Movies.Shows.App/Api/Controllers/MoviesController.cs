using Application.Common.Movies.Commands;
using Application.Common.Movies.Dtos;
using Application.Common.Movies.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {

        public IMediator _mediator;
        public MoviesController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IEnumerable<MovieDto.MovieIndex>> GetMovies()
        {
            return await _mediator.Send(new GetMoviesQuery());
        }
        [HttpGet("{id:int}")]
        public async Task<ActionResult<MovieDto.MovieDetail>> Get([FromRoute] int id)
        {
            var Movies = _mediator.Send(new GetMoviesByIdQuery(id)
            );
            return Ok(Movies);

        }
        [HttpPost]
        public async Task<ActionResult<MovieDto.MovieCreate>> CreateMovie([FromBody] CreateMovieCommand movieCreateCommand)
        {
            var movie = _mediator.Send(movieCreateCommand);
            return Ok(movie);
        }

        //return await todoService.GetTodosAsync(status);


    }
}
