using DesignPatterns.SingletonPattern;

public class Program
{
    private static async void Main(string[] args)
    {
        Console.WriteLine(DateTime.Now.ToLongTimeString);
        var countries = await CountryProvider.Instance.GetCountries();

        foreach (var country in countries)
        {
            Console.WriteLine(country.Name);
        }
    }
}