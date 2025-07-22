using api.Domain.Exceptions;
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
        // Adding global exception and its problem detail service
        services// .AddProblemDetails(configure =>
            // {
            //     configure.CustomizeProblemDetails = context =>
            //     {
            //         context.ProblemDetails.Extensions.TryAdd("requestId", context.HttpContext.TraceIdentifier);
            //     };

            // })
            .AddProblemDetails();
        services.AddExceptionHandler<GlobalExceptionHandler>();

        return services;
    }
}
