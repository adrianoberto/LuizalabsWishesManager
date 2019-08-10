using AutoMapper;
using LuizalabsWishesManager.Domains.Repositories;
using LuizalabsWishesManager.Domains.Services;
using LuizalabsWishesManager.Services;
using Microsoft.Extensions.DependencyInjection;
using LuizalabsWishesManager.Data.Repositories;

namespace LuizalabsWishesManager.Shared
{
    public class IoC
    {
        public static void RegisterMappings(IServiceCollection services)
        {
            services.AddTransient<IMapper, Mapper>();

            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<IWishService, WishService>();

            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddTransient<IWishRepository, WishRepository>();
            services.AddTransient<IWishProductRepository, WishProductRepository>();
        }
    }
}
