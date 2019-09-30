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

        public Dictionary<string,List<Country>> ReadCountries()
        {
            //return null;

            var countries = new Dictionary<string, List<Country>>();

            using (StreamReader sr = new StreamReader(_csvFilePath))
            {
                sr.ReadLine();

                string csvLine;
                while ((csvLine = sr.ReadLine()) != null)
                {
                    Country country = ReadCountryFromCSVLine(csvLine);

                    if (countries.ContainsKey(country.Region))
                    {
                        countries[country.Region].Add(country);
                    }
                    else
                    {
                        List<Country> countryToAdd = new List<Country>() { country };
                        countries.Add(country.Region,countryToAdd);
                    }
                }

            }


            return countries;

        }

        public Country ReadCountryFromCSVLine(string csvLine)
        {
            string[] parts = csvLine.Split(new char[] { ',' });

            string name;
            string code;
            string region;
            string popText;


            switch (parts.Length)
            {
                case 4:
                    name = parts[0];
                    code = parts[1];
                    region = parts[2];
                    popText = parts[3];
                    break;
                case 5:
                    name = parts[0] + " " + parts[1];
                    name = name.Replace("\"", null).Trim();
                    code = parts[2];
                    region = parts[3];
                    popText = parts[4];
                    break;
                default:
                    throw new  Exception($"Can not parse the following line: {csvLine}");      
            }

            int.TryParse(popText, out int population);

            return new Country(name, code, region, population);
        }
    }
}
