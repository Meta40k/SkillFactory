//Создайте консольное приложение,
//в котором будет происходить сортировка списка фамилий из пяти человек.
//Сортировка должна происходить при помощи события.
//Сортировка происходит при введении пользователем либо числа 1 (сортировка А-Я),
//либо числа 2 (сортировка Я-А).

namespace DelegatePractices
{
    class Program
    {
        public delegate void Notify();

        public class ProcessBusinessLogic //Класс издатель.
        {
            public event Notify
                ProcessCompleted; //объявили событие ProcessCompleted делегата Notify, используя ключевое слово event
        }

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

            NumberReader numberReader = new NumberReader();
            numberReader.NumberEnenteredDelegateEvent += ShowNumber;
            numberReader.Read();

            void ShowNumber(int number)
            {
                if (number == 1)
                {
                    foreach (string item in SortAZ(surnames))
                    {
                        Console.WriteLine(item);
                    }
                }

                foreach (string item in SortZA(surnames))
                {
                    Console.WriteLine(item);
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