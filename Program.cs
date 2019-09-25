
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

            Country[] countries = csvReader.ReadFirstNCountries(10);

            foreach (Country country in countries)
            {
                Console.WriteLine($"{country.Name}: {country.Population} ");
            }
            

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
