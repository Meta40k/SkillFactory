//Задание 14.2.4
//Теперь добавьте всех студентов младше 29 лет, владеющих английским языком, в курс «Язык программирования C#». 
//Новая анонимная сущность для выборки должна иметь следующие поля:
//имя (строка);
//год рождения студента (целое число);
//имя курса (строка).

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

        var result = from student in students
            where student.Age < 29
            where student.Languages.Contains("английский")
            from cours in coarses
            where cours.Name.Contains("C#")
            select new
            {
                name = student.Name,
                year = DateTime.Now.Year - student.Age,
                crs = cours.Name
            };

        foreach (var item in result)
        {
            Console.WriteLine(item.name + item.year + item.crs);
        }
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