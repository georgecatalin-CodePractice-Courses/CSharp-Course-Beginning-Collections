
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
            //Country norway = new Country("Norway", "NOR", "Europe", 52822223);
            //Country finland = new Country("Finland", "FIN", "Europe", 5511303);

            //Dictionary<string, Country> countries = new Dictionary<string, Country>();
            //countries.Add(norway.Code, norway);
            //countries.Add(finland.Code, finland);

            //Dictionary<string, Country> countries = new Dictionary<string, Country>()
            //{
            //    {norway.Code,norway },
            //    {finland.Code,finland}
            //};

            //Country selectedCountry = countries["NOR"];
            //Console.WriteLine(selectedCountry.Name);


            //foreach (var item in countries)
            //{
            //    Console.WriteLine(item.Value.Name);
            //}

            //foreach (KeyValuePair<string, Country> item in countries)
            //{
            //    Console.WriteLine(item.Value.Name);
            //}


            //foreach (var item in countries.Values)
            //{
            //    Console.WriteLine(item.Name);
            //}


            //foreach (var item in countries.Keys)
            //{
            //    Console.WriteLine(item);
            //}

            //bool exists = countries.TryGetValue("MAU", out Country selectedCountry);

            //if (exists)
            //{
            //    Console.WriteLine(selectedCountry.Name);
            //}
            //else
            //{
            //    Console.WriteLine("This country does not exist");
            //}

             string filePath = @"D:\CodeLab\Cursuri Pluralsight\Beginning Collections with C#\BeginningCSharp\Pop by Largest Final.csv";

            CsvReader csvReader = new CsvReader(filePath);
            Dictionary<string, Country> countries = csvReader.ReadCountries();

            Console.WriteLine("Enter your country code for search in the dictionary");
            string enteredKeyFromKeyboard = Console.ReadLine();

            bool exists = countries.TryGetValue(enteredKeyFromKeyboard, out Country country);

            if (!exists)
            {
                Console.WriteLine("The country code does not exist in the database");
            }
            else
            {
                Console.WriteLine($"The country name for the {enteredKeyFromKeyboard} is {country.Name} and has the population {country.Population}");
            }


        }
    }
}
