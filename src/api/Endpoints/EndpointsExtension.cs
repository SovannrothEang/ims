using api.Endpoints.Auth;
using api.Endpoints.Products;

namespace api.Endpoints;

public static class EndpointsExtension
{
    public static IEndpointRouteBuilder MapApiEndpoints(this IEndpointRouteBuilder builder)
    {
        var api = builder.MapGroup("/api");
        api.MapProductEndpoints();
        api.MapAuthEndpoints();


        api.MapGet("/test", () => "Test endpoint").WithTags("Test");

        return builder;
    }
}
