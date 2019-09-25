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
            string[] daysOfWeek =
            {
                "Monday",
                "Tuesday",
                "Wenesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            daysOfWeek[2] = "Wednesday";

            foreach (var item in daysOfWeek)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Which day you want to display?");
            Console.WriteLine("Monday=1, etc >");

            int iDay = int.Parse(Console.ReadLine());

            string chosenDay = daysOfWeek[iDay-1];
            Console.WriteLine($"That day is {chosenDay}");

        }
    }
}
