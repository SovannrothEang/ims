using api.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace api;

public static class ServiceCollections
{
    public static IServiceCollection AddServices(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>(option =>
            option.UseNpgsql(configuration.GetConnectionString("NpgsqlConnection")));
        

        return services;
    }
}
