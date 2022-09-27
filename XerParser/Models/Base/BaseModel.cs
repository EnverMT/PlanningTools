using CsvHelper;

namespace XerParser.Models.Base
{
    public abstract class BaseModel<T> : IBaseModel
    {
        public List<T> list = new();
        public void Add(CsvReader csvReader)
        {
            list.Add(csvReader.GetRecord<T>());
        }
    }
}