using api.Application.DTOs.Auth;
using api.Domain.Entities;
using api.Infrastructure.Interfaces;
using api.Mapping.DtoToDomainMapper;
using Microsoft.EntityFrameworkCore;

namespace api.Infrastructure.Repositories;

public class UserRepository(AppDbContext context) : IUserRepository
{
    private readonly AppDbContext _context = context;
    public async Task<User?> Create(RegisterUserDto userDto, CancellationToken token)
    {
        var user = userDto.ToUser();
        await _context.Users.AddAsync(user, cancellationToken: token);
        await _context.SaveChangesAsync(token);
        return user;
        // var createdUser = await _context.Users.FirstOrDefaultAsync(
        //     (u) => u.Id == user.Id,
        //     cancellationToken: token
        // );
        // return createdUser;
    }

    public async Task<User?> FindOneByEmail(string Email, CancellationToken token)
    {
        var user = await _context.Users.FirstOrDefaultAsync(
            (u) => u.Email == Email,
            cancellationToken: token
        );
        return user;
    }
    public async Task<User?> FindOneById(Guid id, CancellationToken token)
    {
        var user = await _context.Users.FirstOrDefaultAsync(
            (u) => u.Id == id,
            cancellationToken: token
        );
        return user;
    }
}
