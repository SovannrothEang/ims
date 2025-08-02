using api.Application.DTOs.Auth;
using api.Application.DTOs.Response;
using api.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace api.Endpoints.Auth.Register;

public class RegisterEndpoint
{
    public static async Task<IResult> Handle(
        [FromBody] RegisterUserDto registerUser,
        [FromServices] IUserService userService,
        CancellationToken token = default
    )
    {
        var user = await userService.Register(registerUser, token);
        if (user is null)
        {
            return Results.BadRequest(
                new ErrorResponse("existing account's info", "")
            );
        }

        return Results.Created(
            "api/auth/me",
            new SuccessResponse<UserResponseDto>(
                user,
                "Created user successfully"
            )
        );
    }
}
