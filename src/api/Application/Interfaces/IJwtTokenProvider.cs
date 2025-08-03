using api.Application.DTOs.Auth;

namespace api.Application.Interfaces;

public interface IJwtTokenProvider
{
    string Create(Payload user);
}
