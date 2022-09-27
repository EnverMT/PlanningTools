using CsvHelper;
using XerParser.Models.Base;
using XerParser.Models.Classes;

namespace XerParser.Models
{
    public class Currtypes : IBaseModel
    {
        public List<Currtype> list = new();
        public void Add(CsvReader csvReader)
        {
            list.Add(csvReader.GetRecord<Currtype>());
        }
    }


}