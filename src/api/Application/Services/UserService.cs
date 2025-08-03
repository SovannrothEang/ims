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
    private readonly PasswordHasher _passwordHasher = new();

    public async Task<UserResponseDto?> Login(LoginUserDto loginUser, CancellationToken token)
    {
        var existedUser = await _userRepository.FindOneByEmail(loginUser.Email, token);
        if (existedUser == null)
        {
            return null;
        }
        if (!_passwordHasher.VerifyPassword(loginUser.Password, existedUser.PasswordHash))
        {
            return null;
        }
        return existedUser.ToUserDto();
    }

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
