using api.Application.DTOs.Auth;
using api.Domain.Entities;

namespace api.Mapping.DomainToDtoMapper;

public static class UserDtoMapper
{
    public static UserResponseDto ToUserDto(this User user)
    {
        return new UserResponseDto
        {
            Id = user.Id,
            Username = user.Username,
            Email = user.Email,
            CreatedAt = user.CreatedAt,
            UpdatedAt = user.UpdatedAt
        };
    }
}
