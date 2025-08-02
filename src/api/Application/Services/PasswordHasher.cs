namespace api.Application.Services;

public class PasswordHasher
{
    public string GetPasswordHash (string password) 
        => BCrypt.Net.BCrypt.EnhancedHashPassword(password, 12);

    public bool VerifyPassword (string inputPassword, string storedHash)
        => BCrypt.Net.BCrypt.EnhancedVerify(inputPassword, storedHash);
}
