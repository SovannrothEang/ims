using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using api.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace api.Endpoints.Auth.User;

public class UserEndpoint
{
    public static async Task<IResult> Handle(
        [FromServices] IUserService userService,
        ClaimsPrincipal claims,
        CancellationToken token = default
    )
    {
        var str = claims.FindFirstValue(ClaimTypes.NameIdentifier)
            ?? throw new UnauthorizedAccessException("Invalid token");

        _ = Guid.TryParse(str, out Guid id);
        var user = await userService.User(id, token);
        if (user is null)
        {
            return Results.NotFound();
        }
        return Results.Ok(user);
    }
}
