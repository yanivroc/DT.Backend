using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using DT.Api.Auth;
using DT.Application.Interfaces;
using DT.Domain.Entities;

namespace DT.Api.Controllers;

public record LoginRequest(string Email, string Password);
public record LoginResponse(string AccessToken, DateTime ExpiresAt, int MemberId, string Role);

[ApiController]
[Route("api/[controller]")]
[AllowAnonymous]
public class AuthController : ControllerBase
{
    private readonly IJwtTokenService _jwt;
    private readonly IGenericRepository<Members> _members;

    public AuthController(IJwtTokenService jwt, IGenericRepository<Members> members)
    {
        _jwt = jwt;
        _members = members;
    }

    /// <summary>
    /// Validates credentials against the Members table.
    /// Role is derived from MemberType: 1 = Admin, 2 = User.
    /// </summary>
    [HttpPost("login")]
    public async Task<ActionResult<LoginResponse>> Login(
        [FromBody] LoginRequest req, CancellationToken ct)
    {
        if (string.IsNullOrWhiteSpace(req.Email) || string.IsNullOrWhiteSpace(req.Password))
            return BadRequest("Email and password required.");

        var member = (await _members.FindAsync(m => m.MemberEmail == req.Email, ct))
            .FirstOrDefault();

        if (member is null || !member.MemberEnable)
            return Unauthorized("Invalid credentials.");

        // NOTE: Existing data appears to store plaintext passwords. When you migrate
        // to a hashed scheme, replace this block with IPasswordHasher<Members>.VerifyHashedPassword.
        if (!string.Equals(member.MemberPassword, req.Password, StringComparison.Ordinal))
            return Unauthorized("Invalid credentials.");

        var role = member.MemberType switch
        {
            1 => "Admin",
            2 => "User",
            _ => "User"
        };

        var token = _jwt.CreateToken(
            userId: member.MemberId.ToString(),
            email: member.MemberEmail,
            roles: new[] { role });

        return Ok(new LoginResponse(
            token,
            DateTime.UtcNow.AddMinutes(120),
            member.MemberId,
            role));
    }
}
