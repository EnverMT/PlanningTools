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
        public DMCA14_Analyzis()
        {
            using (DatabaseManager.ApplicationContext db= new())
            {                
            }
        }
    }
}