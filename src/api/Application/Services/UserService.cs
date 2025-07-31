using api.Application.DTOs.Auth;
using api.Application.Interfaces;
using api.Infrastructure.Interfaces;
using api.Mapping.DomainToDtoMapper;
using Microsoft.AspNetCore.Mvc;

namespace api.Application.Services;

public class UserService(
    [FromServices] IUserRepository userRepository
) : IUserService
{
    private readonly IUserRepository _userRepository = userRepository;

    public async Task<UserResponseDto?> Register(RegisterUserDto registerUser, CancellationToken token)
    {
        // Todo: Validate input values

        var existedUser = await _userRepository.FindOneByEmail(registerUser.Email, token);
        if (existedUser != null)
        {
            return null;
        }
        var user = await _userRepository.Create(registerUser, token);
        return user?.ToUserDto();
    }
    public async Task<UserResponseDto?> User(Guid id, CancellationToken token)
    {
        var user = await _userRepository.FindOneById(id, token);
        return user?.ToUserDto();
    }
}
