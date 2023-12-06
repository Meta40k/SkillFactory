internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите текст:");
  
        // читаем ввод
        var text = Console.ReadLine();
  
        // сохраняем список знаков препинания и символ пробела в коллекцию
        var punctuation = new List< char>() { ' ', ',', '.', ';', ':', '!', '?' };
  
        // валидация ввода
        if (string.IsNullOrEmpty(text))
        {
            Console.WriteLine("Вы ввели пустой текст");
            return;
        }
  
        Console.WriteLine();
        Console.WriteLine("Текст без знаков препинания: ");
        
        // так как строка - это массив char, мы можем вызвать метод  except  и удалить знаки препинания
        var noPunctuation = text.Except(punctuation).ToArray();
  
        // вывод
        Console.WriteLine(noPunctuation);
    }
}