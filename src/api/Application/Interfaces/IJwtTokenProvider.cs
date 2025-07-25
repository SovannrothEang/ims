using api.Domain.Entities;

namespace api.Application.Interfaces;

public interface IJwtTokenProvider
{
    string Create(User user);
}
