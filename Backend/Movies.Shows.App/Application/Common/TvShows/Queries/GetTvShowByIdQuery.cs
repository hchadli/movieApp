using Application.Common.Interfaces;
using Application.Common.Movies.Dtos;
using Application.Common.TvShows.Dtos;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.TvShows.Queries
{
    public record GetTvShowByIdQuery(int id) : IRequest<IEnumerable<TvShowDto.TvShowDetail>>;

    public class GetTvShowByIdQueryHandler : IRequestHandler<GetTvShowByIdQuery, IEnumerable<TvShowDto.TvShowDetail>>
    {



        private readonly IMovieShowsDbContext _dbContext;
        public GetTvShowByIdQueryHandler(IMovieShowsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<TvShowDto.TvShowDetail>> Handle(GetTvShowByIdQuery request, CancellationToken cancellationToken)
        {
            return await _dbContext.TvShows
               .Select(a => new TvShowDto.TvShowDetail()
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