using Api.Dto;
using Application.Common.Interfaces;
using Application.Common.Movies.Dtos;
using Application.Common.TvShows.Dtos;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Common.Actors.Queries
{
    public record GetActorsByIdQuery(int id) : IRequest<ActorDto.ActorDetail>;


    public class GetActorsByIdQueryHandler : IRequestHandler<GetActorsByIdQuery, ActorDto.ActorDetail>
    {
        private readonly IMovieShowsDbContext _dbContext;
        public GetActorsByIdQueryHandler(IMovieShowsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<ActorDto.ActorDetail> Handle(GetActorsByIdQuery request, CancellationToken cancellationToken)
        {
            var actor = await _dbContext.Actors.FindAsync(request.id);

            var actorDto = new ActorDto.ActorDetail()
            {
                Id = actor.Id,
                FirstName = actor.FirstName,
                LastName = actor.LastName,
                Movies = actor.Movies.Select(m => new MovieDto.MovieIndex()
                {
                   Actors     = m.Actors,
                   Genres = m.Genres,
                   Description = m.Description,
                   Id = m.Id,
                   Title = m.Title
                     
                }).ToList(),
                TvShows = actor.TvShows.Select(m => new TvShowDto.TvShowIndex()
                {
                    Genres = m.Genres,
                    Actors = m.Actors.Select(m => new ActorDto.ActorIndex()
                    {
                        Id = m.Id,
                        FirstName = m.FirstName,
                        LastName = m.LastName

                    }).ToList(),
                    TvShowSeasons = m.TvShowSeasons,
                    Title = m.Title,
                    Description = m.Description,
                    Id = m.Id,
                    // ReleaseDate = m.ReleaseDate

                }).ToList()

            };
                return actorDto;
            }
        }

    }
