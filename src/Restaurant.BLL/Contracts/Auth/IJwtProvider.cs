using Restaurant.DAL.Entities;

namespace Restaurant.BLL.Contracts.Auth;

public interface IJwtProvider
{
    string GenerateToken(Client client);
}