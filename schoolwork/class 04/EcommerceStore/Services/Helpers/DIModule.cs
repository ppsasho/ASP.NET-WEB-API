using Data_Access;
using Data_Access.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Services.Helpers
{
    public static class DIModule
    {
        public static IServiceCollection RegisterDbContext (this IServiceCollection services, string connectionString) 
        {
            services.AddDbContext<EcommerceDbContext>
                (opts => opts.UseSqlServer(connectionString));

            //services.AddTransient(typeof(IRepository), typeof(Repository))
            return services;
        }
    }
}
