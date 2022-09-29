using CsvHelper;

namespace XerParser.Classes.Base
{
    public class BaseClass<T>
    {
        protected Parse? _parseContex = null;

        public List<T> list = new();

        public virtual void Add(CsvReader csvReader, Parse? parse = null)
        {
            if (_parseContex == null && parse != null) _parseContex = parse;
            list.Add(csvReader.GetRecord<T>());
        }
    }
}