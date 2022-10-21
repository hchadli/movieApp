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
    public record GetTvShowsQuery : IRequest<IEnumerable<TvShowDto.TvShowIndex>>;

    public class GetTvShowsQueryHandler : IRequestHandler<GetTvShowsQuery, IEnumerable<TvShowDto.TvShowIndex>>
    {
        private readonly IMovieShowsDbContext _dbContext;

        public GetTvShowsQueryHandler(IMovieShowsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<TvShowDto.TvShowIndex>> Handle(GetTvShowsQuery request,
            CancellationToken cancellationToken)
        {
            return await _dbContext.TvShows
                .Include(t => t.Actors)
                .Include(t => t.TvShowSeasons)
                .ThenInclude(s => s.TvShowEpisodes)
                .Select(t => new TvShowDto.TvShowIndex()
                {
                    Id = t.Id,
                    Title = t.Title,
                    Genres = t.Genres,
                    Description = t.Description,
                    ReleaseDate = t.ReleaseDate,
                    Actors = t.Actors.Select(a => new ActorDto.ActorIndex
                    {
                        Id = a.Id,
                        BirthDate = a.BirthDate,
                        FirstName = a.FirstName,
                        LastName = a.LastName
                    }).ToList(),
                    TvShowSeasons = t.TvShowSeasons

                }).ToListAsync(cancellationToken: cancellationToken);
        }
    }
}


