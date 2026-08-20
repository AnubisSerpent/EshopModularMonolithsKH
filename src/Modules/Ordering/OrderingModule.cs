using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Ordering;

public static class OrderingModule
{
    public static IServiceCollection AddOrderingServices(this IServiceCollection services, IConfiguration configuration)
    {
        // Add services for Ordering Module
        return services;
    }
}
