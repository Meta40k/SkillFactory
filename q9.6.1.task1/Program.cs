//Создайте свой тип исключения.
//Сделайте массив из пяти различных видов исключений, включая собственный тип исключения. Реализуйте конструкцию TryCatchFinally, в которой будет итерация на каждый тип исключения (блок finally по желанию).
//В блоке catch выведите в консольном сообщении текст исключения.

namespace DelegatePractices
{
    class Program
    {
        public Exception exc1 = new ArgumentException();
        public Exception exc2 = new ArgumentOutOfRangeException();
        public Exception exc3 = new DirectoryNotFoundException();
        public Exception exc4 = new DivideByZeroException();
        public Exception exc5 = new MyException();
        
        static void Main(string[] args)
        {
            var arr = new Exception[5];
            int nolik = 0;


            try
            {
                var uu = 5 / nolik;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("было деление на ноль");
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine("Недопустимая часть пути к каталогу.");
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Аргумент находится за пределами диапазона допустимых значений.");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Непустой аргумент, передаваемый в метод, является недопустимым.");
            }
            catch (MyException e)
            {
                Console.WriteLine("вот моё исключение исключающее иные исключения.");
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