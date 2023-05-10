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

            Console.WriteLine("Введите имя");
            result.Name = GetAndCheckString();
            Console.WriteLine("Введите Фамилию");
            result.LastName = GetAndCheckString();
            Console.WriteLine("Лет тебе сколько?");
            result.Age = GetAndCheckNumber();
            Console.WriteLine("Питомцы имеются?");
            result.Pets = GetAndCreateArrayPets();
            Console.WriteLine("Любимые цвета есть?");
            result.FavoriteColor = GetAndCreateArrayPets();

            return result;
        }
               
        void OutputOnDisplay(string Name, string LastName, int Age, string[] Pets, string[] FavoriteColor)
        {
            Console.WriteLine($"Имя - {Name}");
            Console.WriteLine($"{Age} от отраду");
            if (Pets.Length > 0)
            {
                PrintArray(Pets);
            }
            else 
            {
                Console.WriteLine("характер скверный, не женат");
            }
            if (FavoriteColor.Length > 0)
            {
                PrintArray(FavoriteColor);
            }
            else
            {
                Console.WriteLine("характер скверный, не женат");
            }
        }

        void PrintArray(string[] arr)
        {
            foreach(string item in arr)
            {
                Console.WriteLine(item);
            }
        }

        string[] GetAndCreateArrayPets()
        {
            Console.WriteLine("начало метода GetAndCreateArrayPets, у вас есть животные/цвета?");
            string answer = Console.ReadLine();
            if (ParseToBoolean(answer))
            {
                Console.WriteLine("и сколько же?");
                int quantity = GetAndCheckNumber();
                string[] result = CreateArray(quantity);
                Console.WriteLine($"По очереди введите, все {quantity} значений!");
                for (int i = 0; i == result.Length; i++)
                {
                    Console.WriteLine($"Живность/цветъ № {i}");
                    result[i] = GetAndCheckString();
                }
                return result;
            }
            Console.WriteLine("Женщины — удивительные создания. Они готовы отдать всю свою любовь собаке, а не человеку. Странные все же они — любительницы животных.");
            return new string[0];
        }

        string[] CreateArray(int quantity)
        {
            string[] result = new string[quantity];

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine($"Введите имя для {i + 1}-го питомца");
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
                Console.WriteLine("Введите строку");
                result = Console.ReadLine();
            }
            while (!string.IsNullOrEmpty(result) || string.IsNullOrWhiteSpace(result));
            return result;
        }

        (string, string, int, string[], string[]) test = GetData();

        OutputOnDisplay(test);
    }
}