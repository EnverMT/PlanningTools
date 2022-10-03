using DatabaseManager.Model;

namespace DMCA
{
    public class DMCA14_Analyzis
    {
        /* To do list:
         * [ ] No Sucesors count
         * [ ] No Predecessors count
         * [ ] Lags
         * [ ] Leads
         * [ ] Relations
         * [ ] Constrains
         * [ ] Large Total float
         * [ ] Negative Total Float
         * [ ] Durations
         * [ ] Check for invalid Dates (no actual dates beyond Data Date)
         * [ ] Resource assignments
         * [ ] Slippage from target
         * [ ] Critical path test (calculated as cirical path length + total float / critical path length)
         * */

        public readonly int ActivitiesCount;
        public readonly int RelationshipsCount;
        public readonly string? ProjectShortName;
        public readonly string? ProjectName;

        public DMCA14_Analyzis(DatabaseManager.Model.Project project)
        {
            using (DatabaseManager.ApplicationContext db = new())
            {
                ProjectShortName = project.ProjShortName;
                ProjectName = db.Projwbs.Where(x => x.ProjId == project.ProjId && x.ProjNodeFlag == "Y")?.FirstOrDefault()?.WbsName;
                ActivitiesCount = db.Tasks.Where(x=>x.ProjId == project.ProjId).Count();
                RelationshipsCount = db.Taskpreds.Where(x=>x.ProjId == project.ProjId).Count();
            }
        }
    }
}