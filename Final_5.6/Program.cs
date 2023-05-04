using System;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        
        void GetData()
        {
            (string Name,
             string LastName,
             int Age,
             bool isHavePets,
             string[] petNames,
             bool isHaveColors,
             string[] favoriteColor) result;

            //Console.WriteLine("Введите имя");
            //result.Item1 = Console.ReadLine();
            //Console.WriteLine("Введите Фамилию");
            //result.Item2 = Console.ReadLine();

            ///Console.WriteLine("Питомцы имеются?");
            //string isHavePets = Console.ReadLine();
        }



        Console.WriteLine("Заполняем возраст");
        int age;
        string data;
        do
        {
            Console.WriteLine("Введите число");
            data = Console.ReadLine();
        }
        while (!int.TryParse(data, out age) && age > 0);

        Console.WriteLine(age);


        int CheckNumber(string data)
        {
            Console.WriteLine("Введите число");
            int result;
            if (!int.TryParse(data, out result))
            {
                Console.WriteLine("Должно быть число. Пробуй ещё раз!");
                CheckNumber(data);
                return result;
            }
            else
            {
               return result = int.Parse(data);
            }
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




        bool CheckString (string data)
        {
            return string.IsNullOrEmpty(data) && string.IsNullOrWhiteSpace(data);
        }

        

    }
}