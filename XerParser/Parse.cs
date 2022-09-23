using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;
using XerParser.Models;

namespace XerParser
{
    public class Parse
    {
        public readonly List<Currtype> currtypesClassList = new();
        public readonly List<Memotype> memotypesClassList = new();

        private readonly string _filePath;
        public Parse(string filePath)
        {
            _filePath = filePath;
            FileInfo fileInfo = new FileInfo(_filePath);
            if (!fileInfo.Exists) throw new FileNotFoundException();

            ReadMultiClassFromCsv();
        }

        public void ReadMultiClassFromCsv()
        {
            string? discriminator = null;
            string? classType = null;

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
                                currtypesClassList.Add(csvReader.GetRecord<Currtype>());
                                break;
                            case "MEMOTYPE":
                                memotypesClassList.Add(csvReader.GetRecord<Memotype>());
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