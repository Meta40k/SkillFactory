//Реализуйте в данном решении анонимный метод, не сломав логику приложения.

namespace DelegatePractices
{
    class Program
    {
        delegate void ShowMessageDelegate(string _message);
        static void Main(string[] args)
        {
            var re = delegate(string name)
            {
                Console.WriteLine("Hello world!");
            };
            
            //re.Invoke("1");
            
            ShowMessageDelegate showMessageDelegate = ShowMessage;
            showMessageDelegate.Invoke("Hello World!");
            Console.Read();
        }

        static void ShowMessage(string _message)
        {
            Console.WriteLine(_message);
        }
        
    }
}