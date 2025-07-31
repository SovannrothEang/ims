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
}
