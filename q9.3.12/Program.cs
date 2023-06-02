//Реализуйте в данном решении анонимный метод, не сломав логику приложения.

namespace DelegatePractices
{
    class Program
    {
        delegate void ShowMessageDelegate(List<string> list);
        static void Main(string[] args)
        {
            List<string> list = new List<string>()
            {
                "Иванов",
                "Яковлев",
                "Петров",
                "Лопаткин",
                "Сидоров",
            };

            foreach (string item in list)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine("");
            Console.WriteLine("-------------------------");
            ShowMessageDelegate PrintDelegate = new ShowMessageDelegate(Print);
            PrintDelegate(list);
            

            void Print(List<string> list)
            {
                foreach (string item in list)
                {
                    Console.WriteLine(item);
                }
            }
        }

        public class MyClass : Exception

        {

        }


    }
}