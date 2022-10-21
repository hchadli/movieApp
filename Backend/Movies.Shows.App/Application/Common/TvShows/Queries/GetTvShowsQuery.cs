using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Api.Dto;
using Application.Common.Actors.Queries;
using Application.Common.Interfaces;
using Application.Common.TvShows.Dtos;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Common.TvShows.Queries
{
    public record GetTvShowsQuery : IRequest<IEnumerable<TvShowDto.Index>>;

    public class GetTvShowsQueryHandler : IRequestHandler<GetTvShowsQuery, IEnumerable<TvShowDto.Index>>
    {
        private readonly IMovieShowsDbContext _dbContext;

        public GetTvShowsQueryHandler(IMovieShowsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<TvShowDto.Index>> Handle(GetTvShowsQuery request,
            CancellationToken cancellationToken)
        {
            return await _dbContext.TvShows
                .Include(t => t.Actors)
                .Include(t => t.TvShowSeasons)
                .Select(t => new TvShowDto.Index()
                {
                    Id = t.Id,
                    Title = t.Title,
                    Genres = t.Genres,
                    Description = t.Description,
                    ReleaseDate = t.ReleaseDate,
                    Actors = t.Actors,
                    TvShowSeasons = t.TvShowSeasons

                }).ToListAsync(cancellationToken: cancellationToken);
        }
    }
}


