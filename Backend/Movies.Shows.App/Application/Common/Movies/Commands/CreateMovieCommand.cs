using MediatR;

namespace Application.Common.Movies.Commands
{
    public class CreateMovieCommand : IRequest<MovieDto.Create>
    {
    }
}
