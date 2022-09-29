using XerParser.Models.Base;

namespace XerParser.Models
{
    public class TASKS : BaseModel<XerParser.Models.Classes.TASK>
    {
        public int Count()
        {
            return list.Count;
        }
    }
}
