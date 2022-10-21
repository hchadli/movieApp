using Application.Common.Interfaces;
using Application.Common.Movies.Dtos;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Common.Movies.Queries
{
    public record GetMoviesQuery : IRequest<IEnumerable<MovieDto.Index>>;



    public class GetMoviesQueryHandler : IRequestHandler<GetMoviesQuery, IEnumerable<MovieDto.Index>>
    {

        private readonly IMovieShowsDbContext _dbContext;
        public GetMoviesQueryHandler(IMovieShowsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<MovieDto.Index>> Handle(GetMoviesQuery request, CancellationToken cancellationToken)
        {
            return await _dbContext.Movies
               .Select(a => new MovieDto.Index()
               {
                   Id = a.Id,
                   Title = a.Title,
                   ReleaseDate = a.ReleaseDate,
                   Genres = a.Genres,
                   Actors = a.Actors,
                   Description = a.Description



               }).ToListAsync(cancellationToken: cancellationToken);
        }
    }
}
