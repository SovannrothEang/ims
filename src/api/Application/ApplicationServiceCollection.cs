using api.Application.Interfaces;
using api.Application.Services;

namespace api.Application;

public static class ApplicationServiceCollection
{
    public static IServiceCollection AddApplicationServiceCollection(
        this IServiceCollection services
    )
    {
        services.AddScoped<IProductService, ProductService>();
        services.AddScoped<IUserService, UserService>();

        return services;
    }
}
