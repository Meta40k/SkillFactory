internal class Program
{
    public static void Main(string[] args)
    {
        // Список студентов
        var students = new List<Student>
        {
            new Student { Name = "Андрей", Age = 23, Languages = new List<string> { "английский", "немецкий" } },
            new Student { Name = "Сергей", Age = 27, Languages = new List<string> { "английский", "французский" } },
            new Student { Name = "Дмитрий", Age = 29, Languages = new List<string> { "английский", "испанский" } }
        };

// Список курсов
        var coarses = new List<Coarse>
        {
            new Coarse { Name = "Язык программирования C#", StartDate = new DateTime(2020, 12, 20) },
            new Coarse { Name = "Язык SQL и реляционные базы данных", StartDate = new DateTime(2020, 12, 15) },
        };
    }

    internal class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public List<string> Languages { get; set; }
    }

    internal class Coarse
    {
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
    }
}