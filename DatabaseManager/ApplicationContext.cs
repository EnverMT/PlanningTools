using Microsoft.EntityFrameworkCore;

namespace DatabaseManager
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Models.ACTVCODE> ActvCode => Set<Models.ACTVCODE>();
        public DbSet<Models.ACTVTYPE> ActvType => Set<Models.ACTVTYPE>();
        public DbSet<Models.CALENDAR> Calendar => Set<Models.CALENDAR>();
        public DbSet<Models.CURRTYPE> CurrType => Set<Models.CURRTYPE>();
        public DbSet<Models.MEMOTYPE> MemoType => Set<Models.MEMOTYPE>();
        public DbSet<Models.NONWORK> NonWork => Set<Models.NONWORK>();
        public DbSet<Models.OBS> Obs => Set<Models.OBS>();
        public DbSet<Models.PROJCOST> ProjCost => Set<Models.PROJCOST>();
        public DbSet<Models.PROJECT> Project => Set<Models.PROJECT>();
        public DbSet<Models.PROJWBS> ProjWbs => Set<Models.PROJWBS>();
        public DbSet<Models.RISKTYPE> RiskType => Set<Models.RISKTYPE>();
        public DbSet<Models.RSRC> Rsrc => Set<Models.RSRC>();
        public DbSet<Models.RSRCCURVDATA> RsrcCurvData => Set<Models.RSRCCURVDATA>();
        public DbSet<Models.RSRCRATE> RsrcRate => Set<Models.RSRCRATE>();
        public DbSet<Models.SCHEDOPTIONS> SchedOptions => Set<Models.SCHEDOPTIONS>();
        public DbSet<Models.TASK> Task => Set<Models.TASK>();
        public DbSet<Models.TASKACTV> TaskActv => Set<Models.TASKACTV>();
        public DbSet<Models.TASKMEMO> TaskMemo => Set<Models.TASKMEMO>();
        public DbSet<Models.TASKPRED> TaskPred => Set<Models.TASKPRED>();
        public DbSet<Models.TASKPROC> TaskProc => Set<Models.TASKPROC>();
        public DbSet<Models.TASKRSRC> TaskRsrc => Set<Models.TASKRSRC>();
        public DbSet<Models.UDFTYPE> UdfType => Set<Models.UDFTYPE>();
        public DbSet<Models.UDFVALUE> UdfValue => Set<Models.UDFVALUE>();
        public DbSet<Models.UMEASURE> Umeasure => Set<Models.UMEASURE>();


        public ApplicationContext() => Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=database.db");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.TASKACTV>().HasKey(u => new { u.task_id, u.actv_code_type_id });
            modelBuilder.Entity<Models.UDFVALUE>().HasKey(u => new { u.udf_code_id, u.fk_id });
        }
    }
}
