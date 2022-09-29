namespace DMCA
{
    public class DMCA14_Analyzis
    {
        public readonly int ActivitiesCount;
        public readonly int RelationshipsCount;
        public DMCA14_Analyzis(XerParser.Parse parse)
        {
            ActivitiesCount = parse.Tasks.list.Count;
            RelationshipsCount = parse.TaskPred.list.Count;
        }
    }
}