using Microsoft.AspNetCore.Mvc;
using Restaurant.BLL.Contracts;
using Restaurant.BLL.DTOs.Client.Auth;
using Restaurant.BLL.Utilities.CustomExceptions;

namespace Restaurant.API.Controllers.V2;

[ApiVersion("2.0")]
[Route("api/v{version:apiVersion}")]
[ApiController]
public class AuthController : ControllerBase
{
    private readonly IServiceManager _serviceManager;
    
    public AuthController(IServiceManager serviceManager)
    {
        _serviceManager = serviceManager;
    }
    
    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody]ClientForLoginDto? client)
    {
        if (client is null)
        {
            return BadRequest("ClientForLoginDto object is null");
        }

        if (!ModelState.IsValid)
        {
            return UnprocessableEntity(ModelState);
        }

        try
        {
            var clientWithTokenDto = await _serviceManager.AuthService.LoginAsync(client);
            
            HttpContext.Response.Cookies.Append("something", clientWithTokenDto.Token!);
        
            return Ok(clientWithTokenDto);
        }
        catch (Exception e) when (e is ClientNotFoundException or InvalidPasswordException)
        {
            return Unauthorized();
        }
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register([FromBody] ClientForRegisterDto? client)
    {
        if (client is null)
        {
            return BadRequest("ClientForRegisterDto object is null");
        }

        if (!ModelState.IsValid)
        {
            return UnprocessableEntity(ModelState);
        }
        
        var clientWithTokenDto = await _serviceManager.AuthService.RegisterAsync(client);
        
        return Ok(clientWithTokenDto);
    }
}