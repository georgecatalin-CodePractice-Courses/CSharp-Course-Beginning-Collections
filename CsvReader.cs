using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginningCSharp
{
    class CsvReader
    {
        private string _csvFilePath;

        public CsvReader(string csvFilePath)
        {
            this._csvFilePath = csvFilePath;
        }

        public Country[] ReadFirstNCountries(int numberOfCountries)
        {
            //return null;

            Country[] country = new Country[numberOfCountries];

            using (StreamReader sr=new StreamReader(_csvFilePath))
            {
                sr.ReadLine();

                for (int i = 0; i < numberOfCountries; i++)
                {
                    string csvLine = sr.ReadLine();
                    country[i] = ReadCountryFromCSVLine(csvLine);
                }
            }


            return country;

        }

        public Country ReadCountryFromCSVLine(string csvLine)
        {
            string[] parts = csvLine.Split(new char[] { ',' });

            string name = parts[0];
            string code = parts[1];
            string region = parts[2];
            int population =int.Parse(parts[3]);

            return new Country(name, code, region, population);
        }
    }
}
