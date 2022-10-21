using Application.Common.Interfaces;
using Application.Common.Movies.Dtos;
using Domain.Entities;
using Domain.Enum;
using MediatR;

namespace Application.Common.Movies.Commands
{
    public record CreateMovieCommand(
     string Title,
     Genre Genres,
     string Description,
     DateTime ReleaseDate
        ) : IRequest<MovieDto.MovieCreate>;



    public class CreateMovieCommandHandler : IRequestHandler<CreateMovieCommand, MovieDto.MovieCreate>
    {

        private readonly IMovieShowsDbContext _dbContext;
        public CreateMovieCommandHandler(IMovieShowsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<MovieDto.MovieCreate> Handle(CreateMovieCommand request, CancellationToken cancellationToken)
        {
            var test = new Movie
            {
                Title = request.Title,
                ReleaseDate = request.ReleaseDate,
                Genres = request.Genres,
                Description = request.Description,

            };

            await _dbContext.Movies.AddAsync(test);
            await _dbContext.SaveChangesAsync(default);



            return new MovieDto.MovieCreate { Title = test.Title, Description = test.Description, Genres = test.Genres, ReleaseDate = request.ReleaseDate };
        }
    }
}
