//Задание 15.1.4
//Напишите метод для поиска общих букв в двух словах.

using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        var word1 = "соловей";
        var word2 = "разбойник";

        static List<char> Method(string word1, string word2)
        {
            var result = word1.Intersect(word2).ToList();
            return result;
        }

        foreach (var c in Method(word1, word2))
        {
            Console.WriteLine(c);
        }
    }
}