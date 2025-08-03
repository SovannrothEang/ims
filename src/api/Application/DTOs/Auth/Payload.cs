using api.Domain.ValueObjects;

namespace api.Application.DTOs.Auth;

public class Payload
{
    public Guid Id { get; set; }
    public string Username { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public UserRole Role { get; set; }
    public DateTime? EmailVerifiedAt { get; set; }
}
