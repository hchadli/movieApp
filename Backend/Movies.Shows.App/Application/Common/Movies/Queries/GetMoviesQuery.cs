using Application.Common.Interfaces;
using Application.Common.Movies.Dtos;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Common.Movies.Queries
{
    public record GetMoviesQuery : IRequest<IEnumerable<MovieDto.MovieIndex>>;

    public class GetMoviesQueryHandler : IRequestHandler<GetMoviesQuery, IEnumerable<MovieDto.MovieIndex>>
    {

        private readonly IMovieShowsDbContext _dbContext;
        public GetMoviesQueryHandler(IMovieShowsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<MovieDto.MovieIndex>> Handle(GetMoviesQuery request, CancellationToken cancellationToken)
        {
            return await _dbContext.Movies
                .Include(m => m.Actors)
                .Select(a => new MovieDto.MovieIndex()
               {
                   Id = a.Id,
                   Title = a.Title,
                   PictureUrl = a.PictureUrl,
                   Genres = a.Genres,
                   Actors = a.Actors,
                   Description = a.Description

               }).ToListAsync();
        }
    }
}
