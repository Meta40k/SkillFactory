//модель города
public class City
{
    public City(string name, long population)
    {
        Name = name;
        Population = population;
    }
          
    public string Name { get; set; }
    public long Population { get; set; }
}