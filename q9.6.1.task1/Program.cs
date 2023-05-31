//Создайте свой тип исключения.
//Сделайте массив из пяти различных видов исключений, включая собственный тип исключения. Реализуйте конструкцию TryCatchFinally, в которой будет итерация на каждый тип исключения (блок finally по желанию).
//В блоке catch выведите в консольном сообщении текст исключения.

using System.Threading.Channels;

namespace DelegatePractices
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new Exception[5]
            {
                new AggregateException(),
                new ArgumentOutOfRangeException(),
                new DirectoryNotFoundException(),
                new DivideByZeroException(),
                new MyException()
            };
            
            int nolik = 0; //это нолик. Да.

            try
            {
                var uu = 5 / nolik;
            }
            catch (Exception ex)
            {
                Console.WriteLine(arr.Contains(ex));
            }
            finally
            {
                Console.WriteLine("Всё нормально, люди в курсе! ");
            }
        }

        public class MyException : Exception
        {
        }


    }
}