

internal class Program
{
    public static void Main(string[] args)
    {
        // Задание 4 Есть массив строк:
        string[] people = { "Анна", "Мария", "Сергей", "Алексей", "Дмитрий", "Ян" };
        // Выбрать имена на букву А:
        foreach (var man in people.Where(name => name.StartsWith("А")))
        {
            Console.WriteLine(man);
        }
        
        
    }
}