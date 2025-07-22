using api.Endpoints.Products;

namespace api.Endpoints;

public static class EndpointsExtension
{
    public static IEndpointRouteBuilder MapApiEndpoints(this IEndpointRouteBuilder builder)
    {
        var api = builder.MapGroup("/api");
        api.MapProductEndpoints();


        api.MapGet("/test", () => "Test endpoint");

        return builder;
    }
}
