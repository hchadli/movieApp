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
using Api.Dto;
using Domain.Entities;

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

        public async Task<TvShowDto.TvShowDetail> Handle(GetTvShowByIdQuery request, CancellationToken cancellationToken)
        {
            return await _dbContext.TvShows
               .Select(a => new TvShowDto.TvShowDetail()
               {
                   Id = a.Id,
                   Title = a.Title,
                   Genres = a.Genres,
                   Actors = a.Actors.Select(m => new ActorDto.ActorIndex()
                   {
                       FirstName = m.FirstName,
                       LastName = m.LastName,
                       Id = m.Id,

                   }).ToList(),
                   Description = a.Description
               }).FirstAsync(t => t.Id == request.id);
        }
    }
}