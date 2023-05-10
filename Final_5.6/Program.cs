using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

internal class Program
{
    private static void Main(string[] args)
    {
        string[] answers = new string[] { "y", "Y", "yes", "Yes", "Да", "да", "Da", "da", "lf" };

        (string, string, int, string[], string[]) GetData()
        {
            (string Name,
             string LastName,
             int Age,
             string[] Pets,
             string[] FavoriteColor) result;

            Console.WriteLine("Заполняем имя");
            result.Name = GetAndCheckString();
            Console.WriteLine("Заполняем Фамилию");
            result.LastName = GetAndCheckString();
            Console.WriteLine("Лет тебе сколько?");
            result.Age = GetAndCheckNumber();
            Console.WriteLine("Питомцы имеются?");
            result.Pets = GetAndCreateArray();
            Console.WriteLine("Заполняем любимые цвета. Они вообще есть у тебя??");
            result.FavoriteColor = GetAndCreateArray();

            return result;
        }
               
        void OutputOnDisplay((string Name, string LastName, int Age, string[] Pets, string[] FavoriteColor) item)
        {
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine($"Звать - {item.Name} {item.LastName}");
            Console.WriteLine($"{item.Age} лет от отраду");
            Console.WriteLine("Список питомцев");
            if (item.Pets.Length > 0)
            {
                PrintArray(item.Pets);
            }
            else 
            {
                Console.WriteLine("Питомцев нет");
            }
            if (item.FavoriteColor.Length > 0)
            {
                PrintArray(item.FavoriteColor);
            }
            else
            {
                Console.WriteLine("Любимые цвета отсутствуют");
            }
        }

        void PrintArray(string[] arr)
        {
            foreach(string item in arr)
            {
                Console.WriteLine(item);
            }
        }

        string[] GetAndCreateArray()
        {
            string answer = Console.ReadLine();
            if (ParseToBoolean(answer))
            {
                Console.WriteLine("и сколько же?");
                int quantity = GetAndCheckNumber();
                string[] result = CreateArray(quantity);
                for (int i = 0; i == result.Length; i++)
                {
                    Console.WriteLine($"Живность/цветъ № {i}");
                    result[i] = GetAndCheckString();
                }
                return result;
            }
            Console.WriteLine("Запомним, что у тебя их нет");
            return new string[0];
        }

        string[] CreateArray(int quantity)
        {
            string[] result = new string[quantity];

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine($"Заполните значение {i + 1}-го");
                result[i] = Console.ReadLine();
            }

            return result;
        }

        bool ParseToBoolean(string answer)
        {
            bool result = false;
            foreach(string item in answers)
            {
                //result = answer == item ? true : false;   
                if (answer.Contains(item))
                {
                    result = true;
                }
            }            
            return result;
        }

        int GetAndCheckNumber()
        {
            int result;
            string data;
            do
            {
                Console.WriteLine("Введите число. Число должно быть больше 0");
                data = Console.ReadLine();
            }
            while (!int.TryParse(data, out result) || (result <= 0));
            return result;
        }
            
        string GetAndCheckString()
        {
            string result;
            do
            {
                Console.WriteLine("Введите строку:");
                result = Console.ReadLine();
            }
            while (string.IsNullOrEmpty(result) || string.IsNullOrWhiteSpace(result));
            return result;
        }


        OutputOnDisplay(GetData());

        
    }
}