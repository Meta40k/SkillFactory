internal class Program
{
    public static void Main(string[] args)
    {
        // Задание 4.  Есть массив строк:
        string[] people = { "Анна", "Мария", "Сергей", "Алексей", "Дмитрий", "Ян" };
        // Выбрать имена на букву А:
        foreach (var man in people.Where(name => name.StartsWith("А")))
        {
            Console.WriteLine(man);
        }


        //Задание 8.  Дан список объектов:
        var objects = new List<object>()
        {
            1,
            "Сергей ",
            "Андрей ",
            300,
        };
        //1. Используйте выражения LINQ, чтобы достать оттуда все имена и вывести их в консоль в алфавитном порядке.
        // objects.Where(object => objects is string);
        var selected = from obj in objects 
            where obj is string 
            orderby obj 
            select obj;
        foreach (var f in selected)
        {
            Console.WriteLine(f);
        }
        
        //2. Перепишите программу из задания выше, используя методы-расширения так,
        //чтобы вывод на консоль и сортировка происходили в две строчки.
        foreach (var name in objects.Where(obj => obj is string).OrderBy(name => name))
            Console.WriteLine(name);
    }
}