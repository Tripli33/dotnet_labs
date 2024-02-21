namespace MasteringLINQ.Entities;

public static class EntityGenerator
{
    private static readonly Random Random = new();

    private static readonly List<string> Names = new()
    {
        "John",
        "Emily",
        "Michael",
        "Sarah",
        "David",
        "Jessica",
        "James",
        "Emma",
        "Daniel",
        "Jennifer",
        "Christopher",
        "Linda",
        "Matthew",
        "Amanda",
        "Andrew",
        "Melissa",
        "Joshua",
        "Michelle",
        "Robert",
        "Susan",
        "Joseph",
        "Karen",
        "Brian",
        "Nicole",
        "Roman"
    };

    public static IEnumerable<Student> GenerateStudents(int numberOfEntities, int maxAge)
    {
        return Enumerable.Range(1, numberOfEntities).Select(index => 
            new Student(Names[Random.Next(24)], Random.Next(18, maxAge), index));
    }

    public static IEnumerable<Audience> GenerateAudiences(int numberOfEntities, int maxAudienceNum, int maxFloor)
    {
        return Enumerable.Range(1, numberOfEntities).Select(index =>
            new Audience(index, Random.Next(1, maxAudienceNum), Random.Next(1, maxFloor)));
    }
}