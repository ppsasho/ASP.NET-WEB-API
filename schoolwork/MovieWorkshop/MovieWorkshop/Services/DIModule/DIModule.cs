using DataAccess;
using DataAccess.Implementations;
using DataAccess.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Services.Implementations;
using Services.Interfaces;

namespace Services.DIModule
{
    public static class DIModule
    {
        public static IServiceCollection Register(this IServiceCollection services, string connectionString)
        {

            services.AddDbContext<MovieWorskshopDbContext>
                (opts => opts.UseSqlServer(connectionString));

            services.AddTransient<IMovieDbRepository, MovieDbRepository>();
            services.AddTransient<IUserDbRepository, UserDbRepository>();

            services.AddTransient<IMovieService, MovieService>();
            services.AddTransient<IUserService, UserService>();

            return services;
        }
    }
}
