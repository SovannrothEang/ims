using System.ComponentModel.DataAnnotations.Schema;
using api.Application.Services;
using api.Domain.ValueObjects;

namespace api.Domain.Entities;

[Table("tbl_users")]
public class User : BaseEntity
{
    private readonly PasswordHasher _hasher = new();
    private string _passwordHash = string.Empty;
    [Column("username")]
    public required string Username { get; set; }
    [Column("email")]
    public required string Email { get; set; }
    [Column("email_verified_at")]
    public DateTime? EmailVerfiedAt { get; set; }
    [Column("password_hash")]
    public required string PasswordHash
    {
        get => _passwordHash;
        set
        {
            if (string.IsNullOrEmpty(value) || value.Length < 8)
            {
                throw new InvalidDataException("Invalid format");
            }
            _passwordHash = _hasher.GetPasswordHash(value);
        }
    }
    [Column("role")]
    public UserRole Role { get; private set; } = UserRole.User;
}
