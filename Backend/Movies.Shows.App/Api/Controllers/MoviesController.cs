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
        public async Task<ActionResult<IEnumerable<MovieDto.Index>>> GetMovies()
        {
            var Movies = _mediator.Send(new GetMoviesQuery
            {

            });
            return Ok(dtos);
        }

        //return await todoService.GetTodosAsync(status);


    }
}
