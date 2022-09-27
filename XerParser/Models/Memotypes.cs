using CsvHelper;
using XerParser.Models.Base;
using XerParser.Models.Classes;

namespace XerParser.Models
{
    public class Memotypes : IBaseModel
    {
        public List<Memotype> list = new();
        public void Add(CsvReader csvReader)
        {
            list.Add(csvReader.GetRecord<Memotype>());
        }
    }
}
