using CsvHelper;

namespace XerParser.Models.Base
{
    public class BaseModel<T> : IBaseModel
    {
        public List<T> list = new();
        public virtual void Add(CsvReader csvReader)
        {
            list.Add(csvReader.GetRecord<T>());
        }
    }
}