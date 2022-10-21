using Api.Dto;
using Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Common.Actors.Queries
{
    public record GetActorsByIdQuery(int id) : IRequest<IEnumerable<ActorDto.ActorDetail>>;


    public class GetActorsByIdQueryHandler : IRequestHandler<GetActorsByIdQuery, IEnumerable<ActorDto.ActorDetail>>
    {
        private readonly IMovieShowsDbContext _dbContext;
        public GetActorsByIdQueryHandler(IMovieShowsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<ActorDto.ActorDetail>> Handle(GetActorsByIdQuery request, CancellationToken cancellationToken)
        {
            return await _dbContext.Actors
                .Select(a => new ActorDto.ActorDetail()
                {
                    Id = a.Id,
                    FirstName = a.FirstName,
                    LastName = a.LastName,
                    BirthDate = a.BirthDate


                }).ToListAsync(cancellationToken: cancellationToken);
        }
    }
}
