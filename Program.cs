
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginningCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"D:\CodeLab\Cursuri Pluralsight\Beginning Collections with C#\BeginningCSharp\Pop by Largest Final.csv";

            CsvReader csvReader = new CsvReader(filePath);

            List<Country> countries = csvReader.ReadCountries();
            Country liliputCountry = new Country("Lilliput", "Code", "Region", 2000000);

            int liliputCountryIndex;

            liliputCountryIndex = countries.FindIndex(x => x.Population < 2000000);
            countries.Insert(liliputCountryIndex, liliputCountry);
            countries.RemoveAt(liliputCountryIndex);

            foreach (Country country in countries)
            {
                Console.WriteLine($"{country.Name}: {country.Population} ");
            }

            Console.WriteLine($"There are {countries.Count} elements in the list.");





            //List<string> daysOfWeek = new List<string>();

            //daysOfWeek.Add("Monday");
            //daysOfWeek.Add("Tuesday");
            //daysOfWeek.Add("Wednesday");
            //daysOfWeek.Add("Thursday");
            //daysOfWeek.Add("Friday");
            //daysOfWeek.Add("Saturday");
            //daysOfWeek.Add("Sunday");

            //List<string> daysOfWeek = new List<string>()
            //{
            //    "Monday",
            //    "Tuesday",
            //    "Wednesday",
            //    "Thursday",
            //    "Friday",
            //    "Saturday",
            //    "Sunday"
            //};

        }
    }
}
