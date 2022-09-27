using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;
using System.Text;
using XerParser.Models;

namespace XerParser
{
    public class Parse
    {
        public readonly List<Currtype> currtypesClassList = new();
        public readonly List<Memotype> memotypesClassList = new();
        public readonly List<Nonwork> nonworkClassList = new();
        public readonly List<OBS> OBSClassList = new();
        public readonly List<Risktype> Risktype = new();

        private readonly string _filePath;
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
                            case "NONWORK":
                                nonworkClassList.Add(csvReader.GetRecord<Nonwork>());
                                break;
                            case "OBS":
                                OBSClassList.Add(csvReader.GetRecord<OBS>());
                                break;
                            case "RISKTYPE":
                                Risktype.Add(csvReader.GetRecord<Risktype>());
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