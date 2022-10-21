using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Api.Dto;
using Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Common.Actors.Queries
{
    public record GetActorsQuery : IRequest<IEnumerable<ActorDto.ActorIndex>>;


    public class GetActorsQueryHandler : IRequestHandler<GetActorsQuery, IEnumerable<ActorDto.ActorIndex>>
    {
        private readonly IMovieShowsDbContext _dbContext;
        public GetActorsQueryHandler(IMovieShowsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<ActorDto.ActorIndex>> Handle(GetActorsQuery request, CancellationToken cancellationToken)
        {
            return await _dbContext.Actors
                .Select(a => new ActorDto.ActorIndex()
                {
                    Id = a.Id,
                    FirstName = a.FirstName,
                    LastName = a.LastName,
                    BirthDate = a.BirthDate

                    
                }).ToListAsync(cancellationToken: cancellationToken);
        }
    }
}

    
    
