using api.Application.DTOs.Auth;
using api.Domain.Entities;

namespace api.Application.Interfaces;

public interface IUserService
{
    Task<UserResponseDto?> Register(RegisterUserDto registerUser, CancellationToken token);
    Task<UserResponseDto?> Login(LoginUserDto loginUser, CancellationToken token);
    Task<UserResponseDto?> User(Guid id, CancellationToken token);
}
