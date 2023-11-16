internal class Program
{
    public static void Main(string[] args)
    {
        // Добавим Россию с её городами
        var russianCities = new List<City>();
        russianCities.Add(new City("Москва", 11900000));
        russianCities.Add(new City("Санкт-Петербург", 4991000));
        russianCities.Add(new City("Волгоград", 1099000));
        russianCities.Add(new City("Казань", 1169000));
        russianCities.Add(new City("Севастополь", 449138));

        // /Задание 14.1.1
        // Выбрать все города, название у которых не длиннее 10 букв,
        // и отсортируйте их по длине названия.
        foreach (var rusCity in russianCities.Where(city => city.Name.Length <= 10).OrderBy(city => city.Name.Length))
            Console.WriteLine(rusCity.Name);

        // Словарь для хранения стран с городами
        var Countries = new Dictionary<string, List<City>>();

// Добавим Россию с её городами
        russianCities.Add(new City("Москва", 11900000));
        russianCities.Add(new City("Санкт-Петербург", 4991000));
        russianCities.Add(new City("Волгоград", 1099000));
        russianCities.Add(new City("Казань", 1169000));
        russianCities.Add(new City("Севастополь", 449138));
        Countries.Add("Россия", russianCities);

// Добавим Беларусь
        var belarusCities = new List<City>();
        belarusCities.Add(new City("Минск", 1200000));
        belarusCities.Add(new City("Витебск", 362466));
        belarusCities.Add(new City("Гродно", 368710));
        Countries.Add("Беларусь", belarusCities);

// Добавим США
        var americanCities = new List<City>();
        americanCities.Add(new City("Нью-Йорк", 8399000));
        americanCities.Add(new City("Вашингтон", 705749));
        americanCities.Add(new City("Альбукерке", 560218));
        Countries.Add("США", americanCities);


        //Задание 14.1.2
        //Дан массив строк:

        string[] test = { "Раз два три", "четыре пять шесть", "семь восемь девять" };
        //Соедините все слова в одну последовательность (каждое слово — отдельный элемент последовательности).
        //Используйте синтаксис LINQ-выражений.
        var result = new List<string>();
        foreach (var block in test)
        {
            string[] word = block.Split(' ');
        }
    }
}