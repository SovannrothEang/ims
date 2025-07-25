using System.Security.Claims;
using System.Text;
using api.Application.Interfaces;
using api.Domain.Entities;
using Microsoft.IdentityModel.JsonWebTokens;
using Microsoft.IdentityModel.Tokens;

namespace api.Application.Services;

internal sealed class JwtTokenProvider(IConfiguration configuration) : IJwtTokenProvider
{
    public string Create(User user)
    {
        // Get secret keys
        string secretKey = configuration["Jwt:Secret"]!;
        if (string.IsNullOrEmpty(secretKey))
            throw new InvalidDataException("Secret key hasn't been assigned yet!");
        // Making security key
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey));
        // Making claims
        var claims = new ClaimsIdentity([
            new Claim(JwtRegisteredClaimNames.Sub, user.Id.ToString()),
            new Claim(JwtRegisteredClaimNames.Email, user.Email)
        ]);
        // Making credential
        var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
        // Making Token Descriptor
        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = claims,
            Expires = DateTime.UtcNow.AddMinutes(configuration.GetValue<int>("Jwt:ExpirationInMinutes")),
            SigningCredentials = credentials,
            Issuer = configuration["Jwt:Issuer"],
            Audience = configuration["Jwt:Audience"]
        };
        // Token handler
        var tokenHandler = new JsonWebTokenHandler();
        // Token
        var token = tokenHandler.CreateToken(tokenDescriptor);
        return token;
    }
}
