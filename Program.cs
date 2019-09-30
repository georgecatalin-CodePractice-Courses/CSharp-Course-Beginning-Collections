
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

            Dictionary<string,List<Country>> countries = csvReader.ReadCountries();

            foreach (string region in countries.Keys)
            {
                Console.WriteLine(region);
            }


            Console.WriteLine("Please enter the region to list its countries");
            string regionEntered = Console.ReadLine();

            if (countries.ContainsKey(regionEntered))
            {
                foreach (Country country in countries[regionEntered].Take(10))
                {
                    Console.WriteLine($"{country.Name}: {country.Population} ");
                }

            }
            else
            {
                Console.WriteLine("This is not a valid region");
            }



            Console.WriteLine($"There are {countries.Count} elements in the list.");



        }
    }
}
