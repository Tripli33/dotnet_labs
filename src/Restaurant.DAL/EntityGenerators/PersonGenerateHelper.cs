namespace Restaurant.DAL.EntityGenerators;
// WARNING: This class is intended for initial data generation only
public static class PersonGenerateHelper
{
    private static readonly Random Random = new();
    private static readonly List<string> Names = new()
    {
        "Alexei",
        "Anastasia",
        "Boris",
        "Daria",
        "Elena",
        "Ivan",
        "Katya",
        "Mikhail",
        "Natalia",
        "Oleg",
        "Svetlana",
        "Vadim",
        "Valentina",
        "Viktor",
        "Yulia",
        "Yuri",
        "Olga",
        "Sergei",
        "Tatiana",
        "Yelena",
        "Dmitry",
        "Irina",
        "Pavel",
        "Marina",
        "Andrei",
        "Anna",
        "Konstantin",
        "Ekaterina",
        "Roman",
        "Maria",
        "Vladimir",
        "Yaroslav",
        "Natalya",
        "Sergey",
        "Tatyana",
        "Marina",
        "Igor",
        "Ekaterina",
        "Nikolai",
        "Elizaveta"
    };

    private static readonly List<string> Streets = new()
    {
        "Lenina Street",
        "Independence Avenue",
        "Kirova Street",
        "Victory Avenue",
        "Oktyabrskaya Street",
        "Frunze Avenue",
        "Gagarina Street",
        "Masherova Avenue",
        "Kosmonavtov Street",
        "Zhukova Avenue",
        "Sovetskaya Street",
        "Karl Marx Avenue",
        "Pervomayskaya Street",
        "Gagarina Avenue",
        "Zheleznodorozhnaya Street",
        "Lenina Avenue",
        "Mira Street",
        "Stalina Avenue",
        "Pushkina Street",
        "Gorkogo Avenue",
        "Suvorova Street",
        "Pushkina Avenue",
        "Komsomolskaya Street",
        "Lenina Square",
        "Gagarina Square",
        "Oktyabrskaya Square",
        "Pervomayskaya Square",
        "Revolyutsii Street",
        "Sovetskaya Square",
        "Karl Marx Street",
        "Lenina Square",
        "Gagarina Street",
        "Kirova Avenue",
        "Oktyabrskaya Avenue",
        "Pushkina Square",
        "Victory Street",
        "Lenina Avenue",
        "Gagarina Street",
        "Mira Avenue",
        "Komsomolskaya Square"
    };

    public static string RandomName() => Names[Random.Next(Names.Count)];
    public static string RandomAddress(int maxStreetNum, int maxApt) => 
        $"{Streets[Random.Next(Streets.Count)]}, {Random.Next(1, maxStreetNum)}, Apt. {Random.Next(1, maxApt)}";
    
    public static string GenerateBelarusPhoneNumber()
    {
        var prefixes = new string[]{ "29", "33", "44", "25" };
        var prefix = prefixes[Random.Next(prefixes.Length)];
        var number = GenerateRandomNumber(7);

        return $"+375{prefix}{number}";
    }
    
    private static string GenerateRandomNumber(int length)
    {
        const string nums = "0123456789";
        
        return new string(Enumerable.Repeat(nums, length)
            .Select(s => s[Random.Next(s.Length)]).ToArray());
    }
}