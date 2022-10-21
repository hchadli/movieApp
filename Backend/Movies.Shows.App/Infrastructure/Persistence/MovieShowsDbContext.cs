using Application.Common.Interfaces;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence
{
    public class MovieShowsDbContext : DbContext, IMovieShowsDbContext
    {
        public DbSet<Actor> Actors => Set<Actor>();
        public DbSet<Media> Medias => Set<Media>();
        public DbSet<Movie> Movies => Set<Movie>();
        public DbSet<TvShow> TvShows => Set<TvShow>();
        public DbSet<TvShowSeason> TvShowSeasons => Set<TvShowSeason>();
        public DbSet<TvShowEpisode> TvShowEpisodes => Set<TvShowEpisode>();

        public MovieShowsDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<TvShow>().HasMany(t => t.TvShowSeasons).WithOne(s => s.)
        }
    }
}
