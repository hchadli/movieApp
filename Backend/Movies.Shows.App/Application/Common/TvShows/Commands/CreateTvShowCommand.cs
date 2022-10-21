using Application.Common.Interfaces;
using Application.Common.TvShows.Dtos;
using Domain.Entities;
using Domain.Enum;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.TvShows.Commands
{
    public record CreateTvShowCommand(
        string title, 
        Genre genres, 
        string description,
        DateTime releaseDate
    ) : IRequest<TvShowDto.TvShowCreate>;

    public class CreateTvShowCommandHandler: IRequestHandler<CreateTvShowCommand, TvShowDto.TvShowCreate>
    {
        private readonly IMovieShowsDbContext _ctx;
        public CreateTvShowCommandHandler(IMovieShowsDbContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<TvShowDto.TvShowCreate> Handle(CreateTvShowCommand request, CancellationToken cancellationToken)
        {
            TvShow tvShow = new()
            {
                Title = request.title,
                Description = request.description,
                Genres = request.genres,
            };

            await _ctx.TvShows.AddAsync(tvShow);
            await _ctx.SaveChangesAsync(default);

            return null;
        }
    }
}
