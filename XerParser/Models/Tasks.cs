using XerParser.Models.Base;
using XerParser.Models.Classes;

namespace XerParser.Models
{
    public class TASKS : BaseModel<XerParser.Models.Classes.TASK>
    {
        public int Count()
        {
            List<TASKRSRC> a = list.FirstOrDefault().SearchResources(_parseContex).Resources;
            return list.Count;
        }
    }
}
