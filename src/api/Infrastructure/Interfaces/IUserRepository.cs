using api.Application.DTOs.Auth;
using api.Domain.Entities;

namespace api.Infrastructure.Interfaces;

public interface IUserRepository
{
    Task<User?> Create(RegisterUserDto userDto, CancellationToken token);
    Task<User?> FindOneByEmail(string Email, CancellationToken token);
    Task<User?> FindOneById(Guid id, CancellationToken token);
}
