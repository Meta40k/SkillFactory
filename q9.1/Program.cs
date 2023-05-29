public class Program 
{
    public delegate int SumDelegate(int a, int b, int c);

    static void Main(string[] args) 
    {
        var dg = delegate(string name)
        {
            return "Привет @" + name + " и добро пожаловать на SkillFactory!";
        };

        Console.WriteLine(dg.Invoke("sasa"));
    }

}