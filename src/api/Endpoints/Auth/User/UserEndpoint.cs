using api.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace api.Endpoints.Auth.User;

public class UserEndpoint
{
    public static async Task<IResult> Handle(
        [FromRoute] Guid id,
        [FromServices] IUserService userService,
        CancellationToken token = default
    )
    {
        var user = await userService.User(id, token);
        if (user is null)
        {
            return Results.NotFound();
        }
        return Results.Ok(user);
    }
}
