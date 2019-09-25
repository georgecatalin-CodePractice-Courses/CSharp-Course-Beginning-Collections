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

        public List<Country> ReadCountries()
        {
            //return null;

            List<Country> country = new List<Country>();

            using (StreamReader sr=new StreamReader(_csvFilePath))
            {
                sr.ReadLine();

                string csvLine;
                while ((csvLine=sr.ReadLine())!=null)
                {
                    country.Add(ReadCountryFromCSVLine(csvLine));
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
