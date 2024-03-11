using Restaurant.DAL.Entities;

namespace Restaurant.DAL.EntityGenerators;
// WARNING: This class is intended for initial data generation only
public static class ClientGenerator
{
    private static readonly Random Random = new();
    
    public static IEnumerable<Client> GenerateClients(int numberOfEntities, int maxStreetNum, int maxApt,
       int minSale, int maxSale) =>
        Enumerable.Range(1, numberOfEntities).Select(i => new Client()
        {
            ClientId = i,
            Name = PersonGenerateHelper.RandomName(),
            Address = PersonGenerateHelper.RandomAddress(maxStreetNum, maxApt),
            Phone = PersonGenerateHelper.GenerateBelarusPhoneNumber(),
            Sale = Random.Next(minSale, maxSale)
        });
}