using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Application.Common.Interfaces
{
    public interface IMovieShowsDbContext
    {
        public DbSet<Actor> Actors { get; }
        public DbSet<Media> Medias { get; }
        public DbSet<Movie> Movies { get; }
        public DbSet<TvShow> TvShows { get; }
        public DbSet<TvShowSeason> TvShowSeasons { get; }
        public DbSet<TvShowEpisode> TvShowEpisodes { get; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
