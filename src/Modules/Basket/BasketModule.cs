using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Basket;

public static class BasketModule
{
    public static IServiceCollection AddBasketServices(this IServiceCollection services, IConfiguration configuration)
    {
        // Add services for Basket Module
        return services;
    }
}
