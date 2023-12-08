//Задание 15.2.8
//Напишите программу с бесконечным циклом, как в предыдущем юните, которая будет:
//ожидать ввода числа с клавиатуры (используйте Console.ReadLine());
//добавлять число в список, хранящийся в памяти;
//выводить после добавления следующую информацию: количество чисел в списке, сумму всех чисел списка, наибольшее и наименьшее числа, а также их среднее значение.

class Program
{
    //   статическая переменная для хранения данных в памяти
    public static List<int> Numbers = new List<int>();

    static void Main(string[] args)
    {
        while (true)
        {
            // Читаем введенный с консоли  текст
            var input = Console.ReadLine();

            // проверяем, число ли это
            var isInteger = Int32.TryParse(input, out int inputNum);

            // если не число - показываем ошибку
            if (!isInteger)
            {
                Console.WriteLine();
                Console.WriteLine("Вы ввели не число");
            }
            // если соответствует, запускаем обработчик
            else
            {
                // добавляем в список
                Numbers.Add(inputNum);

                // выводим все критерии
                Console.WriteLine("Число " + input + " добавлено в список.");
                Console.WriteLine($"Всего в списке  {Numbers.Count} чисел");
                Console.WriteLine($"Сумма:  {Numbers.Sum()}");
                Console.WriteLine($"Наибольшее:  {Numbers.Max()}");
                Console.WriteLine($"Наименьшее:  {Numbers.Min()}");
                Console.WriteLine($"Среднее:  {Numbers.Average()}");
                Console.WriteLine();
            }
        }
    }
}