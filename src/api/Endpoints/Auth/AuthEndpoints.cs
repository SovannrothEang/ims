using api.Endpoints.Auth.Register;
using api.Endpoints.Auth.User;
using api.Endpoints.Login;

namespace api.Endpoints.Auth;

public static class AuthEndpoints
{
    public static IEndpointRouteBuilder MapAuthEndpoints(this IEndpointRouteBuilder builder)
    {
        var auth = builder.MapGroup("/auth")
            .WithTags("Auth");
        auth.MapPost("/login", LoginEndpoint.Handle);
        auth.MapPost("/register", RegisterEndpoint.Handle);
        auth.MapPost("/user", UserEndpoint.Handle)
            .RequireAuthorization()
            .WithName("Get user info");

        return builder;
    }
}
