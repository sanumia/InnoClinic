using Auth.Domain.Enums;

namespace Auth.Domain.Entities;

public class User : Entity
{
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string PasswordHash { get; set; } = string.Empty;
    public Role Role { get; set; }

    public List<RefreshToken> RefreshTokens { get; set; } = new();
}
