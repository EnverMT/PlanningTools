using XerParser.Classes.Base;

namespace XerParser.Classes
{
    public class TASKS : BaseClass<Models.TASK>
    {
        public int Count()
        {
            return list.Count;
        }
    }
}
