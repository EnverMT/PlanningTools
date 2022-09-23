using CsvHelper;
using CsvHelper.Configuration;
using System.Diagnostics;
using System.Globalization;
using XerParser.Models;

namespace XerParser
{
    public class Parse
    {
        private readonly string _filePath;
        public Parse(string filePath)
        {
            _filePath = filePath;
            FileInfo fileInfo = new FileInfo(_filePath);
            if (!fileInfo.Exists) throw new FileNotFoundException();
            string[] allLines = ReadAllLines();

            Debug.WriteLine($"Lines Count: {allLines.Count()}");
            ReadMultiClassFromCsv();
        }

        private string[] ReadAllLines()
        {
            return File.ReadAllLines(_filePath);
        }

        public void ReadMultiClassFromCsv()
        {
            string? discriminator = null;
            string? classType = null;

            var class1Data = new List<Currtype>();
            var class2Data = new List<Memotype>();

            var config = new CsvConfiguration(CultureInfo.CurrentCulture) { Delimiter = "\t" };
            using (var reader = new StreamReader(_filePath))
            using (var csvReader = new CsvReader(reader, config))
            {
                while (csvReader.Read())
                {
                    discriminator = csvReader.GetField<string>(0);

                    if (discriminator == "%T")
                    {
                        classType = csvReader.GetField<string>(1);
                        continue;
                    }

                    if (discriminator == "%F")
                    {
                        csvReader.ReadHeader();
                        continue;
                    }

                    if (discriminator == "%R")
                    {
                        switch (classType)
                        {
                            case "CURRTYPE":
                                class1Data.Add(csvReader.GetRecord<Currtype>());
                                break;
                            case "MEMOTYPE":
                                class2Data.Add(csvReader.GetRecord<Memotype>());
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
        }
    }
}