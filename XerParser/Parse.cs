using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;
using System.Text;
using XerParser.Models;

namespace XerParser
{
    public class Parse
    {
        private readonly string _filePath;
        public Currtypes _Currtypes = new();
        public Memotypes _Memotypes = new();
        public Parse(string filePath, CultureInfo? cultureInfo = null)
        {
            _filePath = filePath;
            if (cultureInfo == null) cultureInfo = CultureInfo.CurrentCulture;

            FileInfo fileInfo = new FileInfo(_filePath);
            if (!fileInfo.Exists) throw new FileNotFoundException();

            ReadMultiClassFromCsv(cultureInfo);
        }

        public void ReadMultiClassFromCsv(CultureInfo cultureInfo)
        {
            string? discriminator = null;
            string? classType = null;

            var config = new CsvConfiguration(cultureInfo)
            {
                Delimiter = "\t",
                BadDataFound = null
            };

            var encoding = CodePagesEncodingProvider.Instance.GetEncoding(1251);

            using (var reader = new StreamReader(_filePath, encoding!))
            using (CsvReader csvReader = new CsvReader(reader, config))
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
                                _Currtypes.Add(csvReader);
                                break;
                            case "MEMOTYPE":
                                _Memotypes.Add(csvReader);
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