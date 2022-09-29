using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;
using System.Text;
using XerParser.Models;
using XerParser.Models.Base;
using XerParser.Models.Classes;

namespace XerParser
{
    public class Parse
    {
        private readonly string _filePath;

        public BaseModel<ACTVCODE> ActvCode = new();
        public BaseModel<ACTVTYPE> ActvType = new();
        public BaseModel<CALENDAR> Calendar = new();
        public BaseModel<CURRTYPE> Currtypes = new();
        public BaseModel<MEMOTYPE> Memotypes = new();
        public BaseModel<NONWORK> Nonwork = new();
        public BaseModel<OBS> Obs = new();
        public BaseModel<PROJCOST> ProjCost = new();
        public BaseModel<PROJECT> Project = new();
        public BaseModel<PROJWBS> ProjWbs = new();
        public BaseModel<RISKTYPE> RiskType = new();
        public BaseModel<RSRC> Rsrc = new();
        public BaseModel<RSRCCURVDATA> RsrcCurvData = new();
        public BaseModel<RSRCRATE> RsrcRate = new();
        public BaseModel<SCHEDOPTIONS> SchedOptions = new();
        public XerParser.Models.TASKS Tasks = new();
        public BaseModel<TASKACTV> TaskActv = new();
        public BaseModel<TASKMEMO> TaskMemo = new();
        public BaseModel<TASKPRED> TaskPred = new();
        public BaseModel<TASKPROC> TaskProc = new();
        public BaseModel<TASKRSRC> TaskRsrc = new();
        public BaseModel<UDFTYPE> UdfType = new();
        public BaseModel<UDFVALUE> UdfValue = new();
        public BaseModel<UMEASURE> Umeasure = new();



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
                                Project.Add(csvReader);
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
                                Tasks.Add(csvReader);
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