using Application.Common.Interfaces;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence
{
    public class MovieShowsDbContext : DbContext, IMovieShowsDbContext
    {
        //public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor> Actors => Set<Actor>();
        //public DbSet<TvShow> TvShows { get; set; }

        public MovieShowsDbContext(DbContextOptions options) : base(options)
        {

        }

        

        protected override void OnModelCreating(ModelBuilder builder)
        {

        }
    }
}
