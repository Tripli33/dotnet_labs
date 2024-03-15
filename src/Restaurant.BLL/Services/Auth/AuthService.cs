using AutoMapper;
using Restaurant.BLL.Contracts.Auth;
using Restaurant.BLL.DTOs;
using Restaurant.BLL.DTOs.Client.Auth;
using Restaurant.BLL.Utilities.CustomExceptions;
using Restaurant.DAL.Contracts;
using Restaurant.DAL.Entities;

namespace Restaurant.BLL.Services.Auth;

public class AuthService : IAuthService
{
    private readonly IRepositoryManager _repositoryManager;
    private readonly IJwtProvider _jwtProvider;
    private readonly IPasswordHasher _passwordHasher;
    private readonly IMapper _mapper;

    public AuthService(IRepositoryManager repositoryManager, IJwtProvider jwtProvider, IPasswordHasher passwordHasher, 
        IMapper mapper)
    {
        _repositoryManager = repositoryManager;
        _jwtProvider = jwtProvider;
        _passwordHasher = passwordHasher;
        _mapper = mapper;
    }
    
    public async Task<ClientWithTokenDto> LoginAsync(ClientForLoginDto clientForLoginDto)
    {
        var client = 
            await _repositoryManager.ClientRepository.GetClientByEmailAsync(clientForLoginDto.Email!, false);

        if (client is null)
        {
            throw new ClientNotFoundException(clientForLoginDto.Email!);
        }

        var isValidPassword = _passwordHasher.Verify(clientForLoginDto.Password!, client.Password!);

        if (!isValidPassword)
        {
            throw new InvalidPasswordException();
        }
        
        var token = _jwtProvider.GenerateToken(client);
        var clientWithTokenDto = _mapper.Map<ClientWithTokenDto>(client)!;
        
        clientWithTokenDto.Token = token;
        
        return clientWithTokenDto;
    }

    public async Task<ClientWithTokenDto> RegisterAsync(ClientForRegisterDto clientForRegisterDto)
    {
        var hashedPassword = _passwordHasher.Generate(clientForRegisterDto.Password!);
        var client = _mapper.Map<Client>(clientForRegisterDto)!;
        
        client.Password = hashedPassword;
        _repositoryManager.ClientRepository.CreateClient(client);
        await _repositoryManager.SaveAsync();
        
        var token = _jwtProvider.GenerateToken(client);
        var clientWithTokenDto = _mapper.Map<ClientWithTokenDto>(client)!;
        
        clientWithTokenDto.Token = token;
        
        return clientWithTokenDto;
    }
}