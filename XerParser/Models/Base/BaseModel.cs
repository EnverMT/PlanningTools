using CsvHelper;

namespace XerParser.Models.Base
{
    public class BaseModel<T>
    {
        protected XerParser.Parse? _parseContex = null;

        public List<T> list = new();

        public virtual void Add(CsvReader csvReader, XerParser.Parse? parse = null)
        {
            if (_parseContex == null && parse != null) _parseContex = parse;
            list.Add(csvReader.GetRecord<T>());
        }
    }
}  //какойн ибудь комментарий