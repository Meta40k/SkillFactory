// 15.6.6 Напишите метод, который соберет всех учеников всех классов в один список, используя LINQ.

using _15;

internal class Program
{
    static void Main(string[] args)
    {
        var classes = new[]
        {
            new Classroom { Students = { "Evgeniy", "Sergey", "Andrew" }, },
            new Classroom { Students = { "Anna", "Viktor", "Vladimir" }, },
            new Classroom { Students = { "Bulat", "Alex", "Galina" }, }
        };
        var allStudents = GetAllStudents(classes);
        var allStudents2 = GetAllStudents(classes);

        Console.WriteLine(string.Join(" ", allStudents));
    }
    
    static string[] GetAllStudents(Classroom[] classes)
    {
        var result = classes.Select(clsr => clsr.Students)
            .SelectMany(namelist => namelist.Select(name => name))
            .ToArray();
        return result;
    }
}