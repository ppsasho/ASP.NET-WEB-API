using Data_Access;
using Data_Access.Implementations;
using Data_Access.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Services.Implementations;
using Services.Interfaces;

namespace Services.Helpers
{
    public static class DIModule
    {
        public static IServiceCollection RegisterDbContextAndServices (this IServiceCollection services, string connectionString) 
        {
            services.AddDbContext<EcommerceDbContext>
                (opts => opts.UseSqlServer(connectionString));

            services.AddTransient(typeof(IRepository<>), typeof(Repository<>));

            services.AddTransient<ICategoryRepository, CategoryRepository>();
            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddTransient<IReviewRepository, ReviewRepository>();
            services.AddTransient<IUserRepository, UserRepository>();

            services.AddTransient<IReviewService, ReviewService>();
            services.AddTransient<ICategoryService, CategoryService>();
            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<IUserService, UserService>();


            return services;
        }
    }
}
