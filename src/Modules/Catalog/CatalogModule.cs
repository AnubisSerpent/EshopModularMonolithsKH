using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Catalog;

public static class CatalogModule
{
    public static IServiceCollection AddCatalogServices(this IServiceCollection services, IConfiguration configuration)
    {
        // Add services for Catalog Module
        return services;
    }
}
