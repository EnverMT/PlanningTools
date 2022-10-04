namespace DatabaseManager.Model
{
    public partial class Project
    {
        public string? WbsName
        {
            get
            {
                string? name = null;
                using (DatabaseManager.ApplicationContext context = new DatabaseManager.ApplicationContext())
                {
                    name = context.Projwbs.Where(x => x.ProjNodeFlag == "Y" && x.ProjId == this.ProjId)?.FirstOrDefault()?.WbsName;                    
                }
                return name;
            }                  
        }
        public List<DatabaseManager.Model.Task> Tasks { get; set; } = new();
    }
}
