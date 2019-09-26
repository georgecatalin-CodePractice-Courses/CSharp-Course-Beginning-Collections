
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


            //foreach (Country country in countries.Take<Country>(10))
            //{
            //    Console.WriteLine($"{country.Name}: {country.Population} ");
            //}

            //Console.WriteLine($"There are {countries.Count} elements in the list.");


            //foreach (Country item in countries.OrderBy(x=>x.Name))
            //{
            //    Console.WriteLine($"{item.Name}: {item.Population} ");
            //}

            //foreach (Country item in countries.OrderBy<Country,string>(x=>x.Name))
            //{
            //     Console.WriteLine($"{item.Name}: {item.Population} ");
            //}

            //foreach (Country item in countries.OrderBy(x=>x.Name).Take(10))
            //{
            //    Console.WriteLine($"{item.Name}: {item.Population} ");
            //}

            //foreach (Country item in countries.Take(20).Where(x=>!x.Name.Contains(',')))
            //{
            //     Console.WriteLine($"{item.Name}: {item.Population} ");
            //}

            //foreach (Country item in countries.Where(x=>!x.Name.Contains(',')).Take(50))
            //{
            //      Console.WriteLine($"{item.Name}: {item.Population} ");
            //}

            //var filteredCountries = countries.Where(x => !x.Name.Contains(',')).Take(10);

            var filteredCountries = from item in countries
                                    where !item.Name.Contains(',')
                                    select item;

            foreach (var item in filteredCountries)
            {
               Console.WriteLine($"{item.Name}: {item.Population} "); 
            }


        }
    }
}
