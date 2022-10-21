using Application.Common.Interfaces;
using Application.Common.Movies.Dtos;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Common.Movies.Queries
{
    public record GetMoviesByIdQuery(int id) : IRequest<MovieDto.MovieDetail>;



    public class GetMoviesByIdQueryHandler : IRequestHandler<GetMoviesByIdQuery, MovieDto.MovieDetail>
    {

        private readonly IMovieShowsDbContext _dbContext;
        public GetMoviesByIdQueryHandler(IMovieShowsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<MovieDto.MovieDetail> Handle(GetMoviesByIdQuery request, CancellationToken cancellationToken)
        {
            return await _dbContext.Movies
                .Select(a => new MovieDto.MovieDetail()
                {
                    Id = a.Id,
                    Title = a.Title,
                    PictureUrl = a.PictureUrl,
                    Genres = a.Genres,
                    Actors = a.Actors,
                    Description = a.Description
                }).FirstAsync(default);
        }
    }
}

