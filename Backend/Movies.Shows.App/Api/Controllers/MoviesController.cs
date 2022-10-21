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
        public async Task<MovieDto.MovieDetail> Get([FromRoute] int id)
        {
            return await _mediator.Send(new GetMoviesByIdQuery(id));
        }

        [HttpPost]
        public async Task<MovieDto.MovieCreate> CreateMovie([FromBody] CreateMovieCommand movieCreateCommand)
        {
            return await _mediator.Send(movieCreateCommand);
        }

        //return await todoService.GetTodosAsync(status);


    }
}
