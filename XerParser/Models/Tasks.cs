using XerParser.Models.Base;
using XerParser.Models.Classes;

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
