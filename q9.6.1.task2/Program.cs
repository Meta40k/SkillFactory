//Создайте консольное приложение,
//в котором будет происходить сортировка списка фамилий из пяти человек.
//Сортировка должна происходить при помощи события.
//Сортировка происходит при введении пользователем либо числа 1 (сортировка А-Я),
//либо числа 2 (сортировка Я-А).

using System.ComponentModel.Design;

namespace DelegatePractices
{
    class Program
    {
        static void Main(string[] args)
        {
            //Стартовый список с фамилиями
            List<string> surnames = new List<string>()
            {
                "Иванов",
                "Петров",
                "Сидоров",
                "Лопаткин",
                "Афанасьев",
                "Яковлев"
            };
            //Выводим список с фамилиями
            foreach (var fam in surnames)
            {
                Console.Write($"{fam} ");
            }

            Console.WriteLine("");
            Console.WriteLine("Для сортировки по алфавиту, нажмите 1");
            Console.WriteLine("Для сортировки в обратном порядке, нажмите 2");
            // var SortSelection = Console.ReadKey();
            var SortSelection = "Console.ReadKey()";

            var sortedList = SortAZ(surnames);
            
            foreach (string fam in sortedList)
            {
                Console.Write($"{fam} ");
            }

            if (SortSelection.Equals("1"))
            {
                foreach (string fam in SortAZ(surnames))
                {
                    Console.Write($"{fam} ");
                }
            }
            else
            {
                foreach (string fam in SortZA(surnames))
                {
                    Console.Write($"{fam} ");
                }
            }
            
            //Метод сортировки списка по алфавиту
            List<string> SortAZ(List<string> list)
            {
                return list.OrderBy(x => x).ToList();
            }
            //Метод сортировки списка в обратном порядке
            List<string> SortZA(List<string> list)
            {
                return list.OrderByDescending(x => x).ToList();
            }
            
        }
    }
}