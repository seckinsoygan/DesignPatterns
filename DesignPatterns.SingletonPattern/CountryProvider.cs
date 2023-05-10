using DesignPatterns.SingletonPattern.Models;

namespace DesignPatterns.SingletonPattern
{
    public class CountryProvider
    {
        private static CountryProvider instance = null;
        public static CountryProvider Instance
        {
            get
            {
                if (instance is not null)
                {
                    return instance;
                }
                else
                {
                    instance = new CountryProvider();
                    return instance;
                }
            }

            set => instance = value;

        }
        public async Task<List<Country>> GetCountries()
        {

            return new List<Country>
            {
                new Country() { Name = "Turkiye" },
                new Country() { Name = "Birlesik Krallik" }
            };
        }
    }
}
