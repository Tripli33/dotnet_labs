using MasteringLINQ.Entities;

var audiences = EntityGenerator.GenerateAudiences(5, 200, 5).ToList();
var students = EntityGenerator.GenerateStudents(5, 25).ToList();

foreach (var student in students.Where(s => s.Id == 3))
{
    Console.WriteLine(student);
}

var studentName = Console.ReadLine();

foreach (var student in students.Where(s => s.Id > 10 && s.Name == studentName))
{
    Console.WriteLine(student);
}

foreach (var audience in audiences.OrderBy(a => a.AudienceFloor))
{
    Console.WriteLine(audience);
}

Console.WriteLine(audiences.Count(a => a.Id > 15));

Console.WriteLine(students.Max(s => s.Age));

Console.WriteLine(students.Average(s => s.Age));