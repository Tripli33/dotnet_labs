using Restaurant.BLL.DTOs;
using Restaurant.BLL.DTOs.Client.Auth;

namespace Restaurant.BLL.Contracts.Auth;

public interface IAuthService
{
    Task<ClientWithTokenDto> LoginAsync(ClientForLoginDto clientForLoginDto);
    Task<ClientWithTokenDto> RegisterAsync(ClientForRegisterDto clientForRegisterDto);
}