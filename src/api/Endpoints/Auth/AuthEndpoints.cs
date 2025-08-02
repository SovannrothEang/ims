using api.Endpoints.Auth.Register;

namespace api.Endpoints.Auth;

public static class AuthEndpoints
{
    public static IEndpointRouteBuilder MapAuthEndpoints(this IEndpointRouteBuilder builder)
    {
        var auth = builder.MapGroup("/auth")
            .WithTags("Auth");
        auth.MapPost("/register", RegisterEndpoint.Handle);

        return builder;
    }
}
