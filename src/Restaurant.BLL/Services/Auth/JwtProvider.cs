using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Restaurant.BLL.Contracts.Auth;
using Restaurant.DAL.Entities;

namespace Restaurant.BLL.Services.Auth;

public class JwtProvider : IJwtProvider
{
    private readonly IConfiguration _configuration;
    
    public JwtProvider(IConfiguration configuration)
    {
        _configuration = configuration;
    }
    
    public string GenerateToken(Client client)
    {
        var secretKey = _configuration["JWTOptions:SecretKey"];
        var expiresHours =  Convert.ToDouble(_configuration["JWTOptions:ExpiresHours"]);
        
        var claims = new[]
        {
            new Claim(ClaimTypes.NameIdentifier, client.ClientId.ToString()),
            new Claim(ClaimTypes.Email, client.Email!)
        }; 
        
        var signingCredentials = new SigningCredentials(
            new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey!)),
            SecurityAlgorithms.HmacSha256);

        var token = new JwtSecurityToken(
            claims: claims,
            signingCredentials: signingCredentials,
            expires: DateTime.UtcNow.AddHours(expiresHours));

        var tokenValue = new JwtSecurityTokenHandler().WriteToken(token);

        return tokenValue;
    }
}