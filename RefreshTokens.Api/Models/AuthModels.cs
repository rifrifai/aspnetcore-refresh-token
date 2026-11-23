namespace RefreshTokens.Api.Models;

public record class RegisterRequest(string FirstName, string LastName, string Email, string Password);

public record class LoginRequest(string Email, string Password);

public record class RefreshRequest(string RefreshToken);

public record class RevokeRequest(string RefreshToken);

public record class AuthResponse(
    string UserId,
    string Email,
    IEnumerable<string> Roles,
    string AccessToken,
    DateTime AccessTokenExpiresAt,
    string RefreshToken,
    DateTime RefreshTokenExpiresAt
);
