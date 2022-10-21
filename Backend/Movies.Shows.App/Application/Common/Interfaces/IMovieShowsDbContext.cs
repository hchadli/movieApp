using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Application.Common.Interfaces
{
    public interface IMovieShowsDbContext
    {
        public DbSet<Actor> Actors { get; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
