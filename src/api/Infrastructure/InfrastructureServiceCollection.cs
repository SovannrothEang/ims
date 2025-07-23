using api.Infrastructure.Interfaces;
using api.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

namespace api.Infrastructure;

public static class InfrastructureServiceCollection
{
    public static IServiceCollection AddInfrastructureServiceCollection(
        this IServiceCollection services,
        IConfiguration configuration )
    {
        services.AddDbContext<AppDbContext>(option =>
            option.UseNpgsql(configuration.GetConnectionString("NpgsqlConnection")));
        services.AddScoped<IProductRepository, ProductRepository>();

        return services;
    }
}
