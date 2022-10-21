using Application.Common.Interfaces;
using Infrastructure.Persistence;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {

            var connection = new SqliteConnection("DataSource=:memory:");
            connection.Open();
            services.AddDbContext<MovieShowsDbContext>(options =>
            {
                options.UseSqlite(connection);
            });

            services.AddScoped<IMovieShowsDbContext>(collection => collection.GetRequiredService<MovieShowsDbContext>());


            services.AddDbContext<MovieShowsDbContext>(opt =>
                opt.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
                    b => b.MigrationsAssembly(typeof(MovieShowsDbContext).Assembly.FullName)));

            return services;
        }
    }
}
