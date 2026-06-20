using Microsoft.AspNetCore.Mvc;
using DT.Api.Auth;

namespace DT.Api.Controllers;

public record LoginRequest(string Email, string Password);
public record LoginResponse(string AccessToken, DateTime ExpiresAt);

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly IJwtTokenService _jwt;
    public AuthController(IJwtTokenService jwt) { _jwt = jwt; }

    /// <summary>Demo login. Replace with real credential check against Members table.</summary>
    [HttpPost("login")]
    public ActionResult<LoginResponse> Login([FromBody] LoginRequest req)
    {
        // TODO: Validate against Members/Users table using IGenericRepository<Members> + password hash check.
        if (string.IsNullOrWhiteSpace(req.Email) || string.IsNullOrWhiteSpace(req.Password))
            return BadRequest("Email and password required.");
        var token = _jwt.CreateToken(userId: "demo", email: req.Email, roles: new[] { "User" });
        return Ok(new LoginResponse(token, DateTime.UtcNow.AddMinutes(120)));
    }
}
