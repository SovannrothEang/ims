using api.Application;
using api.Application.Interfaces;
using api.Application.Services;
using api.Domain.Exceptions;
using api.Infrastructure;

namespace api;

public static class ServiceCollection
{
    public static IServiceCollection AddServiceCollection(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        services
            .AddSingleton<IJwtTokenProvider, JwtTokenProvider>()
            .AddApplicationServiceCollection()
            .AddInfrastructureServiceCollection(configuration);
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
