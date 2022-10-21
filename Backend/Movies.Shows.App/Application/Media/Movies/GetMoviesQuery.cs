using Api.Dto;
using MediatR;

namespace Application.Media.Movies
{
    public class GetMoviesQuery : IRequest<MediaDto.Index>
    {
    }
}
