using Application.Common.Interfaces;
using Domain.Entities;
using Domain.Enum;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System.Linq;

namespace Infrastructure.Persistence
{
    public class MovieShowsDbContext : DbContext, IMovieShowsDbContext
    {
        public DbSet<Actor> Actors => Set<Actor>();
        public DbSet<Movie> Movies => Set<Movie>();
        public DbSet<TvShow> TvShows => Set<TvShow>();
        public DbSet<TvShowSeason> TvShowSeasons => Set<TvShowSeason>();
        public DbSet<TvShowEpisode> TvShowEpisodes => Set<TvShowEpisode>();

        public MovieShowsDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<TvShow>()
                .HasMany(t => t.TvShowSeasons)
                .WithOne(s => s.TvShow)
                .HasForeignKey(s => s.TvShowId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<TvShowSeason>()
                .HasMany(s => s.TvShowEpisodes)
                .WithOne(e => e.TvShowSeason)
                .HasForeignKey(e => e.TvShowSeasonId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<Actor>()
                .HasMany(a => a.Movies)
                .WithMany(m => m.Actors);

            builder.Entity<Actor>()
                .HasMany(a => a.TvShows)
                .WithMany(m => m.Actors);

            builder.Entity<Actor>()
                .Property(a => a.BirthDate)
                .HasColumnType("DateTime");

            builder.Entity<Movie>()
                .Property(a => a.ReleaseDate)
                .HasColumnType("DateTime");

            builder.Entity<TvShow>()
                .Property(a => a.ReleaseDate)
                .HasColumnType("DateTime");

            builder.Entity<TvShowSeason>()
                .Property(a => a.ReleaseDate)
                .HasColumnType("DateTime");

            builder.Entity<TvShowEpisode>()
                .Property(a => a.ReleaseDate)
                .HasColumnType("DateTime");

            builder.Entity<Movie>()
                .Property(m => m.Genres)
                .HasConversion(new EnumToNumberConverter<Genre, int>());

            builder.Entity<TvShow>()
                .Property(m => m.Genres)
                .HasConversion(new EnumToNumberConverter<Genre, int>());
        }
    }
}
