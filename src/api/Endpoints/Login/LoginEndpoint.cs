using api.Application.DTOs.Auth;
using api.Application.DTOs.Response;
using api.Application.Interfaces;
using api.Application.Services;
using api.Mapping.DtoToDomainMapper;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace api.Endpoints.Login;

public class LoginEndpoint
{
    public static async Task<IResult> Handle(
        LoginUserDto loginUser,
        [FromServices] IUserService userService,
        [FromServices] IJwtTokenProvider jwtTokenProvider,
        CancellationToken cancellationToken
    )
    {
        var userDto = await userService.Login(loginUser, cancellationToken);
        if (userDto is null)
        {
            return Results.BadRequest(
                new ErrorResponse("Invalid credentials", null)
            );
        }
        var token = jwtTokenProvider.Create(userDto.ToPayload());
        if (string.IsNullOrEmpty(token))
        {
            return Results.InternalServerError();
        }
        return Results.Ok(
            new SuccessResponse<string>(token, "Login successfully")
        );
    }
}
