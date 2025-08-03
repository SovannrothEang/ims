using api.Application.DTOs.Auth;
using api.Domain.Entities;

namespace api.Mapping.DtoToDomainMapper;

public static class UserMapper
{
    public static User ToUser(this RegisterUserDto registerUser)
    {
        return new User
        {
            Username = registerUser.Username,
            Email = registerUser.Email,
            PasswordHash = registerUser.Password
        };
    }
    public static User ToUser(this UserResponseDto userResponseDto)
    {
        return new User
        {
            Id = userResponseDto.Id,
            Username = userResponseDto.Username,
            Email = userResponseDto.Email,
            EmailVerifiedAt = userResponseDto.EmailVerfiedAt,
            Role = userResponseDto.Role,
            CreatedAt = userResponseDto.CreatedAt,
            UpdatedAt = userResponseDto.UpdatedAt
        };
    }
}
