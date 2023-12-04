// Наш список студентов

using q14;

List<Student> students = new List<Student>
{
    new Student { Name = "Андрей", Age = 23, Languages = new List<string> { "английский", "немецкий" } },
    new Student { Name = "Сергей", Age = 27, Languages = new List<string> { "английский", "французский" } },
    new Student { Name = "Дмитрий", Age = 29, Languages = new List<string> { "английский", "испанский" } },
    new Student { Name = "Василий", Age = 24, Languages = new List<string> { "испанский", "немецкий" } }
};

//Выберите всех студентов моложе 27, сгенерируйте из них анкеты (модель класса расположена ниже).
//При вычислении года рождения используйте ключевое слово let.

var result = from s in students
    let yearOfBirth = DateTime.Now.Year - s.Age
    where s.Age < 27
    select new Application()
    {
        Name = s.Name,
        YearOfBirth = yearOfBirth
    };

foreach (var item in result)

    Console.WriteLine(item.Name);