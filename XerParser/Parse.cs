using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;
using System.Text;
using XerParser.Classes;
using XerParser.Classes.Base;
using Models;

namespace XerParser
{
    public class Parse
    {
        private readonly string _filePath;

        public BaseClass<ACTVCODE> ActvCode = new();
        public BaseClass<ACTVTYPE> ActvType = new();
        public BaseClass<CALENDAR> Calendar = new();
        public BaseClass<CURRTYPE> Currtypes = new();
        public BaseClass<MEMOTYPE> Memotypes = new();
        public BaseClass<NONWORK> Nonwork = new();
        public BaseClass<OBS> Obs = new();
        public BaseClass<PROJCOST> ProjCost = new();
        public BaseClass<PROJECT> Project = new();
        public BaseClass<PROJWBS> ProjWbs = new();
        public BaseClass<RISKTYPE> RiskType = new();
        public BaseClass<RSRC> Rsrc = new();
        public BaseClass<RSRCCURVDATA> RsrcCurvData = new();
        public BaseClass<RSRCRATE> RsrcRate = new();
        public BaseClass<SCHEDOPTIONS> SchedOptions = new();
        public TASKS Tasks = new();
        public BaseClass<TASKACTV> TaskActv = new();
        public BaseClass<TASKMEMO> TaskMemo = new();
        public BaseClass<TASKPRED> TaskPred = new();
        public BaseClass<TASKPROC> TaskProc = new();
        public BaseClass<TASKRSRC> TaskRsrc = new();
        public BaseClass<UDFTYPE> UdfType = new();
        public BaseClass<UDFVALUE> UdfValue = new();
        public BaseClass<UMEASURE> Umeasure = new();



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
                    string? discriminator = csvReader.GetField<string>(0);

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
                            case "ACTVCODE":
                                ActvCode.Add(csvReader);
                                break;
                            case "ACTVTYPE":
                                ActvType.Add(csvReader);
                                break;
                            case "CALENDAR":
                                Calendar.Add(csvReader);
                                break;
                            case "CURRTYPE":
                                Currtypes.Add(csvReader);
                                break;
                            case "MEMOTYPE":
                                Memotypes.Add(csvReader);
                                break;
                            case "NONWORK":
                                Nonwork.Add(csvReader);
                                break;
                            case "OBS":
                                Obs.Add(csvReader);
                                break;
                            case "PROJCOST":
                                ProjCost.Add(csvReader);
                                break;
                            case "PROJECT":
                                Project.Add(csvReader, this);
                                break;
                            case "PROJWBS":
                                ProjWbs.Add(csvReader);
                                break;
                            case "RISKTYPE":
                                RiskType.Add(csvReader);
                                break;
                            case "RSRC":
                                Rsrc.Add(csvReader);
                                break;
                            case "RSRCCURVDATA":
                                RsrcCurvData.Add(csvReader);
                                break;
                            case "RSRCRATE":
                                RsrcRate.Add(csvReader);
                                break;
                            case "SCHEDOPTIONS":
                                SchedOptions.Add(csvReader);
                                break;
                            case "TASK":
                                Tasks.Add(csvReader, this);
                                break;
                            case "TASKACTV":
                                TaskActv.Add(csvReader);
                                break;
                            case "TASKMEMO":
                                TaskMemo.Add(csvReader);
                                break;
                            case "TASKPRED":
                                TaskPred.Add(csvReader);
                                break;
                            case "TASKPROC":
                                TaskProc.Add(csvReader);
                                break;
                            case "TASKRSRC":
                                TaskRsrc.Add(csvReader);
                                break;
                            case "UDFTYPE":
                                UdfType.Add(csvReader);
                                break;
                            case "UDFVALUE":
                                UdfValue.Add(csvReader);
                                break;
                            case "UMEASURE":
                                Umeasure.Add(csvReader);
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