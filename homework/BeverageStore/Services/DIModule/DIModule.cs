using Data_Access;
using Data_Access.Implementations;
using Data_Access.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Services.Implementations;
using Services.Interfaces;

namespace Services.DIModule
{
    public static class DIModule
    {
        public static IServiceCollection RegisterDependencies(this IServiceCollection services, string connString) 
        {
            services.AddDbContext<BeverageStoreDbContext>
                (opts => opts.UseSqlServer(connString));

            services.AddTransient(typeof(IRepository<>), typeof(Repository<>));

            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IBeverageRepository, BeverageRepository>();
            services.AddTransient<IOrderRepository, OrderRepository>();

            services.AddTransient<IUserService, UserService>();

            return services;
        }
    }
}
