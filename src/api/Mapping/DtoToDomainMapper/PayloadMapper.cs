using api.Application.DTOs.Auth;

namespace api.Mapping.DtoToDomainMapper;

public static class PayloadMapper
{
    public static Payload ToPayload(this UserResponseDto userResponse)
    {
        return new Payload
        {
            Id = userResponse.Id,
            Username = userResponse.Username,
            Email = userResponse.Email,
            EmailVerifiedAt = userResponse.EmailVerfiedAt,
            Role = userResponse.Role
        };
    }
}
