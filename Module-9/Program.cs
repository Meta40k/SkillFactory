Exception[] exceptions = new Exception[5];
exceptions[0] = new MyException("кастом эксепшн");
exceptions[1] = new NullReferenceException();
exceptions[2] = new FormatException();
exceptions[3] = new DivideByZeroException();
exceptions[4] = new TimeoutException();
TestException(exceptions);

void TestException(Exception[] exceptions)
{
    foreach (Exception ex in exceptions)

        try
        {
            throw ex;
        }
        catch (MyException)
        {
            Console.WriteLine($"Сработало исключение {ex.GetType()} с сообщением {ex.Message}");
        }
        catch (NullReferenceException)
        {
            Console.WriteLine($"Сработало исключение {ex.GetType()} с сообщением {ex.Message}");
        }
        catch (FormatException)
        {
            Console.WriteLine($"Сработало исключение {ex.GetType()} с сообщением {ex.Message}");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine($"Сработало исключение {ex.GetType()} с сообщением {ex.Message}");
        }
        catch (TimeoutException)
        {
            Console.WriteLine($"Сработало исключение {ex.GetType()} с сообщением {ex.Message}");
        }
}