//Задание 9.3.4
//Реализуйте консольное приложение, в котором существует две функции:
//первая функция вычитает второе число из первого и отображает результат в консольном сообщении,
//вторая функция складывает два числа и отображает результат в консоли.
//Реализуйте вызов этих двух функций через многоадресный делегат.


public class Program 
{
    public delegate void Delegate2Func(int x, int y);

    static void Main(string[] args)
    {

        Delegate2Func dele = FirstFunc;
        dele += SecondFunc;
        dele.Invoke(300,10);

        static void VDfunc()
        {
            Console.WriteLine("rapapapapa");
        }
        
        static void FirstFunc(int number1, int number2)
        {
            int result = number2 - number1;
            Console.WriteLine(result);
            
        }static void SecondFunc(int number1, int number2)
        {
            int result = number1 + number2;
            Console.WriteLine(result);
        }
    }
}
