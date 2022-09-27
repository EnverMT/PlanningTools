using CsvHelper;

namespace XerParser.Models.Base
{
    public interface IBaseModel
    {
        void Add(CsvReader csvReader);
    }
}