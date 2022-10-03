using DatabaseManager.Model;
using Microsoft.EntityFrameworkCore;

namespace DatabaseManager
{
    public partial class ApplicationContext : DbContext
    {
        public ApplicationContext()
        {
        }

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; } = null!;
        public virtual DbSet<Actvcode> Actvcodes { get; set; } = null!;
        public virtual DbSet<Actvtype> Actvtypes { get; set; } = null!;
        public virtual DbSet<AdminConfig> AdminConfigs { get; set; } = null!;
        public virtual DbSet<Asgnmntacat> Asgnmntacats { get; set; } = null!;
        public virtual DbSet<Asgnmntcattype> Asgnmntcattypes { get; set; } = null!;
        public virtual DbSet<Asgnmntcatval> Asgnmntcatvals { get; set; } = null!;
        public virtual DbSet<Basetype> Basetypes { get; set; } = null!;
        public virtual DbSet<Budgchng> Budgchngs { get; set; } = null!;
        public virtual DbSet<Calendar> Calendars { get; set; } = null!;
        public virtual DbSet<Costtype> Costtypes { get; set; } = null!;
        public virtual DbSet<Currtype> Currtypes { get; set; } = null!;
        public virtual DbSet<Discussion> Discussions { get; set; } = null!;
        public virtual DbSet<DiscussionRead> DiscussionReads { get; set; } = null!;
        public virtual DbSet<Dltacct> Dltaccts { get; set; } = null!;
        public virtual DbSet<Dltactv> Dltactvs { get; set; } = null!;
        public virtual DbSet<Dltob> Dltobs { get; set; } = null!;
        public virtual DbSet<Dltrole> Dltroles { get; set; } = null!;
        public virtual DbSet<Dltrsrc> Dltrsrcs { get; set; } = null!;
        public virtual DbSet<Dltrsrl> Dltrsrls { get; set; } = null!;
        public virtual DbSet<Dltuser> Dltusers { get; set; } = null!;
        public virtual DbSet<Doccatg> Doccatgs { get; set; } = null!;
        public virtual DbSet<Docstat> Docstats { get; set; } = null!;
        public virtual DbSet<Document> Documents { get; set; } = null!;
        public virtual DbSet<Expproj> Expprojs { get; set; } = null!;
        public virtual DbSet<Extapp> Extapps { get; set; } = null!;
        public virtual DbSet<Factor> Factors { get; set; } = null!;
        public virtual DbSet<Factval> Factvals { get; set; } = null!;
        public virtual DbSet<Filtprop> Filtprops { get; set; } = null!;
        public virtual DbSet<Findate> Findates { get; set; } = null!;
        public virtual DbSet<Fintmpl> Fintmpls { get; set; } = null!;
        public virtual DbSet<Fundsrc> Fundsrcs { get; set; } = null!;
        public virtual DbSet<Gchange> Gchanges { get; set; } = null!;
        public virtual DbSet<Imagedatum> Imagedata { get; set; } = null!;
        public virtual DbSet<Issuhist> Issuhists { get; set; } = null!;
        public virtual DbSet<Jobsvc> Jobsvcs { get; set; } = null!;
        public virtual DbSet<Location> Locations { get; set; } = null!;
        public virtual DbSet<Memotype> Memotypes { get; set; } = null!;
        public virtual DbSet<Nextkey> Nextkeys { get; set; } = null!;
        public virtual DbSet<Ob> Obs { get; set; } = null!;
        public virtual DbSet<OpeningAccount> OpeningAccounts { get; set; } = null!;
        public virtual DbSet<OpeningActvcode> OpeningActvcodes { get; set; } = null!;
        public virtual DbSet<OpeningOb> OpeningObs { get; set; } = null!;
        public virtual DbSet<OpeningRole> OpeningRoles { get; set; } = null!;
        public virtual DbSet<OpeningRsrc> OpeningRsrcs { get; set; } = null!;
        public virtual DbSet<OpeningRsrcrole> OpeningRsrcroles { get; set; } = null!;
        public virtual DbSet<OpeningUser> OpeningUsers { get; set; } = null!;
        public virtual DbSet<Pcattype> Pcattypes { get; set; } = null!;
        public virtual DbSet<Pcatval> Pcatvals { get; set; } = null!;
        public virtual DbSet<PfloadView> PfloadViews { get; set; } = null!;
        public virtual DbSet<Pfolio> Pfolios { get; set; } = null!;
        public virtual DbSet<Phase> Phases { get; set; } = null!;
        public virtual DbSet<Pkxref> Pkxrefs { get; set; } = null!;
        public virtual DbSet<Pob> Pobs { get; set; } = null!;
        public virtual DbSet<Prefer> Prefers { get; set; } = null!;
        public virtual DbSet<Procgroup> Procgroups { get; set; } = null!;
        public virtual DbSet<Procitem> Procitems { get; set; } = null!;
        public virtual DbSet<Profile> Profiles { get; set; } = null!;
        public virtual DbSet<Profpriv> Profprivs { get; set; } = null!;
        public virtual DbSet<Projcost> Projcosts { get; set; } = null!;
        public virtual DbSet<Project> Projects { get; set; } = null!;
        public virtual DbSet<Projest> Projests { get; set; } = null!;
        public virtual DbSet<Projfund> Projfunds { get; set; } = null!;
        public virtual DbSet<Projissu> Projissus { get; set; } = null!;
        public virtual DbSet<Projpcat> Projpcats { get; set; } = null!;
        public virtual DbSet<Projprop> Projprops { get; set; } = null!;
        public virtual DbSet<Projrisk> Projrisks { get; set; } = null!;
        public virtual DbSet<Projshar> Projshars { get; set; } = null!;
        public virtual DbSet<Projthr> Projthrs { get; set; } = null!;
        public virtual DbSet<Projwb> Projwbs { get; set; } = null!;
        public virtual DbSet<Prpfolio> Prpfolios { get; set; } = null!;
        public virtual DbSet<Rcattype> Rcattypes { get; set; } = null!;
        public virtual DbSet<Rcatval> Rcatvals { get; set; } = null!;
        public virtual DbSet<Refrdel> Refrdels { get; set; } = null!;
        public virtual DbSet<Rfolio> Rfolios { get; set; } = null!;
        public virtual DbSet<Risktype> Risktypes { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<Rolecattype> Rolecattypes { get; set; } = null!;
        public virtual DbSet<Rolecatval> Rolecatvals { get; set; } = null!;
        public virtual DbSet<Rolelimit> Rolelimits { get; set; } = null!;
        public virtual DbSet<Rolerate> Rolerates { get; set; } = null!;
        public virtual DbSet<Rolercat> Rolercats { get; set; } = null!;
        public virtual DbSet<Rpt> Rpts { get; set; } = null!;
        public virtual DbSet<Rptbatch> Rptbatches { get; set; } = null!;
        public virtual DbSet<Rptgroup> Rptgroups { get; set; } = null!;
        public virtual DbSet<Rptlist> Rptlists { get; set; } = null!;
        public virtual DbSet<Rsrc> Rsrcs { get; set; } = null!;
        public virtual DbSet<Rsrccurv> Rsrccurvs { get; set; } = null!;
        public virtual DbSet<Rsrcrate> Rsrcrates { get; set; } = null!;
        public virtual DbSet<Rsrcrcat> Rsrcrcats { get; set; } = null!;
        public virtual DbSet<Rsrcrole> Rsrcroles { get; set; } = null!;
        public virtual DbSet<Rsrcsec> Rsrcsecs { get; set; } = null!;
        public virtual DbSet<Rsrfolio> Rsrfolios { get; set; } = null!;
        public virtual DbSet<Setting> Settings { get; set; } = null!;
        public virtual DbSet<Shift> Shifts { get; set; } = null!;
        public virtual DbSet<Shiftper> Shiftpers { get; set; } = null!;
        public virtual DbSet<Sumtask> Sumtasks { get; set; } = null!;
        public virtual DbSet<Sumtaskspread> Sumtaskspreads { get; set; } = null!;
        public virtual DbSet<Sumtrsrc> Sumtrsrcs { get; set; } = null!;
        public virtual DbSet<DatabaseManager.Model.Task> Tasks { get; set; } = null!;
        public virtual DbSet<Taskactv> Taskactvs { get; set; } = null!;
        public virtual DbSet<Taskdoc> Taskdocs { get; set; } = null!;
        public virtual DbSet<Taskfdbk> Taskfdbks { get; set; } = null!;
        public virtual DbSet<Taskfin> Taskfins { get; set; } = null!;
        public virtual DbSet<Taskmemo> Taskmemos { get; set; } = null!;
        public virtual DbSet<Tasknote> Tasknotes { get; set; } = null!;
        public virtual DbSet<Taskpred> Taskpreds { get; set; } = null!;
        public virtual DbSet<Taskproc> Taskprocs { get; set; } = null!;
        public virtual DbSet<Taskrisk> Taskrisks { get; set; } = null!;
        public virtual DbSet<Taskrsrc> Taskrsrcs { get; set; } = null!;
        public virtual DbSet<Taskuser> Taskusers { get; set; } = null!;
        public virtual DbSet<Thrsparm> Thrsparms { get; set; } = null!;
        public virtual DbSet<Trakview> Trakviews { get; set; } = null!;
        public virtual DbSet<Trsrcfin> Trsrcfins { get; set; } = null!;
        public virtual DbSet<Udfcode> Udfcodes { get; set; } = null!;
        public virtual DbSet<Udftype> Udftypes { get; set; } = null!;
        public virtual DbSet<Udfvalue> Udfvalues { get; set; } = null!;
        public virtual DbSet<Umeasure> Umeasures { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<Usercol> Usercols { get; set; } = null!;
        public virtual DbSet<Userdatum> Userdata { get; set; } = null!;
        public virtual DbSet<Usereng> Userengs { get; set; } = null!;
        public virtual DbSet<Userob> Userobs { get; set; } = null!;
        public virtual DbSet<Userset> Usersets { get; set; } = null!;
        public virtual DbSet<Usession> Usessions { get; set; } = null!;
        public virtual DbSet<Viewprop> Viewprops { get; set; } = null!;
        public virtual DbSet<Wbrscat> Wbrscats { get; set; } = null!;
        public virtual DbSet<Wbsbudg> Wbsbudgs { get; set; } = null!;
        public virtual DbSet<Wbsmemo> Wbsmemos { get; set; } = null!;
        public virtual DbSet<Wbsrsrc> Wbsrsrcs { get; set; } = null!;
        public virtual DbSet<WbsrsrcQty> WbsrsrcQties { get; set; } = null!;
        public virtual DbSet<Wbsstep> Wbssteps { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source=c:\\ins\\PMDB_20_test_local_2.db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(entity =>
            {
                entity.HasKey(e => e.AcctId);

                entity.ToTable("ACCOUNT");

                entity.Property(e => e.AcctId)
                    .ValueGeneratedNever()
                    .HasColumnName("ACCT_ID");

                entity.Property(e => e.AcctDescr).HasColumnName("ACCT_DESCR");

                entity.Property(e => e.AcctName)
                    .HasColumnType("TEXT(100)")
                    .HasColumnName("ACCT_NAME");

                entity.Property(e => e.AcctSeqNum).HasColumnName("ACCT_SEQ_NUM");

                entity.Property(e => e.AcctShortName)
                    .HasColumnType("TEXT(40)")
                    .HasColumnName("ACCT_SHORT_NAME");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.ParentAcctId).HasColumnName("PARENT_ACCT_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");
            });

            modelBuilder.Entity<Actvcode>(entity =>
            {
                entity.ToTable("ACTVCODE");

                entity.HasIndex(e => e.ActvCodeTypeId, "ndx_actvcode_actv_code_type_id");

                entity.Property(e => e.ActvCodeId)
                    .ValueGeneratedNever()
                    .HasColumnName("ACTV_CODE_ID");

                entity.Property(e => e.ActvCodeName)
                    .HasColumnType("TEXT(120)")
                    .HasColumnName("ACTV_CODE_NAME");

                entity.Property(e => e.ActvCodeTypeId).HasColumnName("ACTV_CODE_TYPE_ID");

                entity.Property(e => e.Color)
                    .HasColumnType("TEXT(6)")
                    .HasColumnName("COLOR");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.ParentActvCodeId).HasColumnName("PARENT_ACTV_CODE_ID");

                entity.Property(e => e.SeqNum).HasColumnName("SEQ_NUM");

                entity.Property(e => e.ShortName)
                    .HasColumnType("TEXT(60)")
                    .HasColumnName("SHORT_NAME");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");
            });

            modelBuilder.Entity<Actvtype>(entity =>
            {
                entity.HasKey(e => e.ActvCodeTypeId);

                entity.ToTable("ACTVTYPE");

                entity.HasIndex(e => e.ProjId, "ndx_actvtype_proj_id");

                entity.Property(e => e.ActvCodeTypeId)
                    .ValueGeneratedNever()
                    .HasColumnName("ACTV_CODE_TYPE_ID");

                entity.Property(e => e.ActvCodeType)
                    .HasColumnType("TEXT(40)")
                    .HasColumnName("ACTV_CODE_TYPE");

                entity.Property(e => e.ActvCodeTypeScope)
                    .HasColumnType("TEXT(10)")
                    .HasColumnName("ACTV_CODE_TYPE_SCOPE");

                entity.Property(e => e.ActvShortLen).HasColumnName("ACTV_SHORT_LEN");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.ProjId).HasColumnName("PROJ_ID");

                entity.Property(e => e.SeqNum).HasColumnName("SEQ_NUM");

                entity.Property(e => e.SuperFlag)
                    .HasColumnType("TEXT(1)")
                    .HasColumnName("SUPER_FLAG");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");
            });

            modelBuilder.Entity<AdminConfig>(entity =>
            {
                entity.HasKey(e => e.ConfigName);

                entity.ToTable("ADMIN_CONFIG");

                entity.Property(e => e.ConfigName)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CONFIG_NAME");

                entity.Property(e => e.ConfigData).HasColumnName("CONFIG_DATA");

                entity.Property(e => e.ConfigType)
                    .HasColumnType("TEXT(10)")
                    .HasColumnName("CONFIG_TYPE");

                entity.Property(e => e.ConfigValue)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CONFIG_VALUE");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.FactoryVersion)
                    .HasColumnType("TEXT(10)")
                    .HasColumnName("FACTORY_VERSION");

                entity.Property(e => e.LastChangeDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("LAST_CHANGE_DATE");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");
            });

            modelBuilder.Entity<Asgnmntacat>(entity =>
            {
                entity.HasKey(e => new { e.TaskrsrcId, e.AsgnmntCatgTypeId });

                entity.ToTable("ASGNMNTACAT");

                entity.Property(e => e.TaskrsrcId).HasColumnName("TASKRSRC_ID");

                entity.Property(e => e.AsgnmntCatgTypeId).HasColumnName("ASGNMNT_CATG_TYPE_ID");

                entity.Property(e => e.AsgnmntCatgId).HasColumnName("ASGNMNT_CATG_ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.ProjId).HasColumnName("PROJ_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");
            });

            modelBuilder.Entity<Asgnmntcattype>(entity =>
            {
                entity.HasKey(e => e.AsgnmntCatgTypeId);

                entity.ToTable("ASGNMNTCATTYPE");

                entity.Property(e => e.AsgnmntCatgTypeId)
                    .ValueGeneratedNever()
                    .HasColumnName("ASGNMNT_CATG_TYPE_ID");

                entity.Property(e => e.AsgnmntCatgShortLen).HasColumnName("ASGNMNT_CATG_SHORT_LEN");

                entity.Property(e => e.AsgnmntCatgType)
                    .HasColumnType("TEXT(60)")
                    .HasColumnName("ASGNMNT_CATG_TYPE");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.SeqNum).HasColumnName("SEQ_NUM");

                entity.Property(e => e.SuperFlag)
                    .HasColumnType("TEXT(1)")
                    .HasColumnName("SUPER_FLAG")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");
            });

            modelBuilder.Entity<Asgnmntcatval>(entity =>
            {
                entity.HasKey(e => e.AsgnmntCatgId);

                entity.ToTable("ASGNMNTCATVAL");

                entity.Property(e => e.AsgnmntCatgId)
                    .ValueGeneratedNever()
                    .HasColumnName("ASGNMNT_CATG_ID");

                entity.Property(e => e.AsgnmntCatgName)
                    .HasColumnType("TEXT(100)")
                    .HasColumnName("ASGNMNT_CATG_NAME");

                entity.Property(e => e.AsgnmntCatgShortName)
                    .HasColumnType("TEXT(60)")
                    .HasColumnName("ASGNMNT_CATG_SHORT_NAME");

                entity.Property(e => e.AsgnmntCatgTypeId).HasColumnName("ASGNMNT_CATG_TYPE_ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.ParentAsgnmntCatgId).HasColumnName("PARENT_ASGNMNT_CATG_ID");

                entity.Property(e => e.SeqNum).HasColumnName("SEQ_NUM");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");
            });

            modelBuilder.Entity<Basetype>(entity =>
            {
                entity.ToTable("BASETYPE");

                entity.Property(e => e.BaseTypeId)
                    .ValueGeneratedNever()
                    .HasColumnName("BASE_TYPE_ID");

                entity.Property(e => e.BaseType1)
                    .HasColumnType("TEXT(40)")
                    .HasColumnName("BASE_TYPE");

                entity.Property(e => e.BaseTypeSeqNum).HasColumnName("BASE_TYPE_SEQ_NUM");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");
            });

            modelBuilder.Entity<Budgchng>(entity =>
            {
                entity.ToTable("BUDGCHNG");

                entity.HasIndex(e => e.ProjId, "ndx_budgchng_proj_id");

                entity.Property(e => e.BudgChngId)
                    .ValueGeneratedNever()
                    .HasColumnName("BUDG_CHNG_ID");

                entity.Property(e => e.ChngByName)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CHNG_BY_NAME");

                entity.Property(e => e.ChngCost).HasColumnName("CHNG_COST");

                entity.Property(e => e.ChngDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CHNG_DATE");

                entity.Property(e => e.ChngDescr)
                    .HasColumnType("TEXT(130)")
                    .HasColumnName("CHNG_DESCR");

                entity.Property(e => e.ChngShortName)
                    .HasColumnType("TEXT(32)")
                    .HasColumnName("CHNG_SHORT_NAME");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.ProjId).HasColumnName("PROJ_ID");

                entity.Property(e => e.StatusCode)
                    .HasColumnType("TEXT(30)")
                    .HasColumnName("STATUS_CODE");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.WbsId).HasColumnName("WBS_ID");
            });

            modelBuilder.Entity<Calendar>(entity =>
            {
                entity.HasKey(e => e.ClndrId);

                entity.ToTable("CALENDAR");

                entity.HasIndex(e => e.ProjId, "ndx_calendar_proj_id");

                entity.Property(e => e.ClndrId)
                    .ValueGeneratedNever()
                    .HasColumnName("CLNDR_ID");

                entity.Property(e => e.BaseClndrId).HasColumnName("BASE_CLNDR_ID");

                entity.Property(e => e.ClndrData).HasColumnName("CLNDR_DATA");

                entity.Property(e => e.ClndrName)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CLNDR_NAME");

                entity.Property(e => e.ClndrType)
                    .HasColumnType("TEXT(16)")
                    .HasColumnName("CLNDR_TYPE");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.DayHrCnt).HasColumnName("DAY_HR_CNT");

                entity.Property(e => e.DefaultFlag)
                    .HasColumnType("TEXT(1)")
                    .HasColumnName("DEFAULT_FLAG");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.LastChngDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("LAST_CHNG_DATE");

                entity.Property(e => e.MonthHrCnt).HasColumnName("MONTH_HR_CNT");

                entity.Property(e => e.ProjId).HasColumnName("PROJ_ID");

                entity.Property(e => e.RsrcPrivate)
                    .HasColumnType("TEXT(1)")
                    .HasColumnName("RSRC_PRIVATE");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.WeekHrCnt).HasColumnName("WEEK_HR_CNT");

                entity.Property(e => e.YearHrCnt).HasColumnName("YEAR_HR_CNT");
            });

            modelBuilder.Entity<Costtype>(entity =>
            {
                entity.ToTable("COSTTYPE");

                entity.Property(e => e.CostTypeId)
                    .ValueGeneratedNever()
                    .HasColumnName("COST_TYPE_ID");

                entity.Property(e => e.CostType1)
                    .HasColumnType("TEXT(36)")
                    .HasColumnName("COST_TYPE");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.SeqNum).HasColumnName("SEQ_NUM");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");
            });

            modelBuilder.Entity<Currtype>(entity =>
            {
                entity.HasKey(e => e.CurrId);

                entity.ToTable("CURRTYPE");

                entity.Property(e => e.CurrId)
                    .ValueGeneratedNever()
                    .HasColumnName("CURR_ID");

                entity.Property(e => e.BaseExchRate).HasColumnName("BASE_EXCH_RATE");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.CurrShortName)
                    .HasColumnType("TEXT(6)")
                    .HasColumnName("CURR_SHORT_NAME");

                entity.Property(e => e.CurrSymbol)
                    .HasColumnType("TEXT(6)")
                    .HasColumnName("CURR_SYMBOL");

                entity.Property(e => e.CurrType1)
                    .HasColumnType("TEXT(40)")
                    .HasColumnName("CURR_TYPE");

                entity.Property(e => e.DecimalDigitCnt).HasColumnName("DECIMAL_DIGIT_CNT");

                entity.Property(e => e.DecimalSymbol)
                    .HasColumnType("TEXT(6)")
                    .HasColumnName("DECIMAL_SYMBOL");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.DigitGroupSymbol)
                    .HasColumnType("TEXT(6)")
                    .HasColumnName("DIGIT_GROUP_SYMBOL");

                entity.Property(e => e.GroupDigitCnt).HasColumnName("GROUP_DIGIT_CNT");

                entity.Property(e => e.NegCurrFmtType)
                    .HasColumnType("TEXT(20)")
                    .HasColumnName("NEG_CURR_FMT_TYPE");

                entity.Property(e => e.PosCurrFmtType)
                    .HasColumnType("TEXT(20)")
                    .HasColumnName("POS_CURR_FMT_TYPE");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");
            });

            modelBuilder.Entity<Discussion>(entity =>
            {
                entity.ToTable("DISCUSSION");

                entity.HasIndex(e => e.TaskId, "ndx_discussion_task_id");

                entity.Property(e => e.DiscussionId)
                    .ValueGeneratedNever()
                    .HasColumnName("DISCUSSION_ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.DiscussionDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DISCUSSION_DATE");

                entity.Property(e => e.DiscussionValue)
                    .HasColumnType("TEXT(4000)")
                    .HasColumnName("DISCUSSION_VALUE");

                entity.Property(e => e.TaskId).HasColumnName("TASK_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.UserId).HasColumnName("USER_ID");
            });

            modelBuilder.Entity<DiscussionRead>(entity =>
            {
                entity.HasKey(e => new { e.DiscussionId, e.UserId });

                entity.ToTable("DISCUSSION_READ");

                entity.Property(e => e.DiscussionId).HasColumnName("DISCUSSION_ID");

                entity.Property(e => e.UserId).HasColumnName("USER_ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");
            });

            modelBuilder.Entity<Dltacct>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DLTACCT");

                entity.Property(e => e.AcctId).HasColumnName("ACCT_ID");

                entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            });

            modelBuilder.Entity<Dltactv>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DLTACTV");

                entity.Property(e => e.ActvCodeId).HasColumnName("ACTV_CODE_ID");

                entity.Property(e => e.ParentActvCodeId).HasColumnName("PARENT_ACTV_CODE_ID");

                entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            });

            modelBuilder.Entity<Dltob>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DLTOBS");

                entity.Property(e => e.ObsId).HasColumnName("OBS_ID");

                entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            });

            modelBuilder.Entity<Dltrole>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DLTROLE");

                entity.Property(e => e.RoleId).HasColumnName("ROLE_ID");

                entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            });

            modelBuilder.Entity<Dltrsrc>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DLTRSRC");

                entity.Property(e => e.RsrcId).HasColumnName("RSRC_ID");

                entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            });

            modelBuilder.Entity<Dltrsrl>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DLTRSRL");

                entity.Property(e => e.RoleId).HasColumnName("ROLE_ID");

                entity.Property(e => e.RsrcId).HasColumnName("RSRC_ID");

                entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            });

            modelBuilder.Entity<Dltuser>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DLTUSER");

                entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");

                entity.Property(e => e.UserId).HasColumnName("USER_ID");
            });

            modelBuilder.Entity<Doccatg>(entity =>
            {
                entity.ToTable("DOCCATG");

                entity.Property(e => e.DocCatgId)
                    .ValueGeneratedNever()
                    .HasColumnName("DOC_CATG_ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.DocCatgName)
                    .HasColumnType("TEXT(100)")
                    .HasColumnName("DOC_CATG_NAME");

                entity.Property(e => e.SeqNum).HasColumnName("SEQ_NUM");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");
            });

            modelBuilder.Entity<Docstat>(entity =>
            {
                entity.HasKey(e => e.DocStatusId);

                entity.ToTable("DOCSTAT");

                entity.Property(e => e.DocStatusId)
                    .ValueGeneratedNever()
                    .HasColumnName("DOC_STATUS_ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.DocStatusCode)
                    .HasColumnType("TEXT(36)")
                    .HasColumnName("DOC_STATUS_CODE");

                entity.Property(e => e.SeqNum).HasColumnName("SEQ_NUM");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");
            });

            modelBuilder.Entity<Document>(entity =>
            {
                entity.HasKey(e => e.DocId);

                entity.ToTable("DOCUMENT");

                entity.HasIndex(e => e.ProjId, "ndx_document_proj_id");

                entity.Property(e => e.DocId)
                    .ValueGeneratedNever()
                    .HasColumnName("DOC_ID");

                entity.Property(e => e.AuthorName)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("AUTHOR_NAME");

                entity.Property(e => e.CrExternalDocKey)
                    .HasColumnType("TEXT(4000)")
                    .HasColumnName("CR_EXTERNAL_DOC_KEY");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.DelivFlag)
                    .HasColumnType("TEXT(1)")
                    .HasColumnName("DELIV_FLAG");

                entity.Property(e => e.DocCatgId).HasColumnName("DOC_CATG_ID");

                entity.Property(e => e.DocContent).HasColumnName("DOC_CONTENT");

                entity.Property(e => e.DocDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DOC_DATE");

                entity.Property(e => e.DocMgmtType)
                    .HasColumnType("TEXT(10)")
                    .HasColumnName("DOC_MGMT_TYPE");

                entity.Property(e => e.DocName)
                    .HasColumnType("TEXT(120)")
                    .HasColumnName("DOC_NAME");

                entity.Property(e => e.DocSeqNum).HasColumnName("DOC_SEQ_NUM");

                entity.Property(e => e.DocShortName)
                    .HasColumnType("TEXT(32)")
                    .HasColumnName("DOC_SHORT_NAME");

                entity.Property(e => e.DocStatusId).HasColumnName("DOC_STATUS_ID");

                entity.Property(e => e.Guid)
                    .HasColumnType("TEXT(22)")
                    .HasColumnName("GUID");

                entity.Property(e => e.ParentDocId).HasColumnName("PARENT_DOC_ID");

                entity.Property(e => e.PrivateLoc)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("PRIVATE_LOC");

                entity.Property(e => e.ProjId).HasColumnName("PROJ_ID");

                entity.Property(e => e.PublicLoc)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("PUBLIC_LOC");

                entity.Property(e => e.TmplGuid)
                    .HasColumnType("TEXT(22)")
                    .HasColumnName("TMPL_GUID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.VersionName)
                    .HasColumnType("TEXT(20)")
                    .HasColumnName("VERSION_NAME");
            });

            modelBuilder.Entity<Expproj>(entity =>
            {
                entity.HasKey(e => e.ProjId);

                entity.ToTable("EXPPROJ");

                entity.Property(e => e.ProjId)
                    .ValueGeneratedNever()
                    .HasColumnName("PROJ_ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.ExpGroup)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("EXP_GROUP");

                entity.Property(e => e.ExpPasswd)
                    .HasColumnType("TEXT(60)")
                    .HasColumnName("EXP_PASSWD");

                entity.Property(e => e.ExpProjName)
                    .HasColumnType("TEXT(100)")
                    .HasColumnName("EXP_PROJ_NAME");

                entity.Property(e => e.ExpUserName)
                    .HasColumnType("TEXT(40)")
                    .HasColumnName("EXP_USER_NAME");

                entity.Property(e => e.LoginSuppliedFlag)
                    .HasColumnType("TEXT(1)")
                    .HasColumnName("LOGIN_SUPPLIED_FLAG");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");
            });

            modelBuilder.Entity<Extapp>(entity =>
            {
                entity.HasKey(e => e.AppId);

                entity.ToTable("EXTAPP");

                entity.HasIndex(e => e.ProjId, "ndx_extapp_proj_id");

                entity.Property(e => e.AppId)
                    .ValueGeneratedNever()
                    .HasColumnName("APP_ID");

                entity.Property(e => e.AppDataLoc)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("APP_DATA_LOC");

                entity.Property(e => e.AppDataName)
                    .HasColumnType("TEXT(100)")
                    .HasColumnName("APP_DATA_NAME");

                entity.Property(e => e.AppExeName)
                    .HasColumnType("TEXT(100)")
                    .HasColumnName("APP_EXE_NAME");

                entity.Property(e => e.AppName)
                    .HasColumnType("TEXT(100)")
                    .HasColumnName("APP_NAME");

                entity.Property(e => e.AppParmString)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("APP_PARM_STRING");

                entity.Property(e => e.AppPasswd)
                    .HasColumnType("TEXT(100)")
                    .HasColumnName("APP_PASSWD");

                entity.Property(e => e.AppUserName)
                    .HasColumnType("TEXT(40)")
                    .HasColumnName("APP_USER_NAME");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.LoginSupplyFlag)
                    .HasColumnType("TEXT(1)")
                    .HasColumnName("LOGIN_SUPPLY_FLAG");

                entity.Property(e => e.ProjId).HasColumnName("PROJ_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");
            });

            modelBuilder.Entity<Factor>(entity =>
            {
                entity.HasKey(e => e.FactId);

                entity.ToTable("FACTOR");

                entity.Property(e => e.FactId)
                    .ValueGeneratedNever()
                    .HasColumnName("FACT_ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.DefFactValId).HasColumnName("DEF_FACT_VAL_ID");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.FactDescr).HasColumnName("FACT_DESCR");

                entity.Property(e => e.FactName)
                    .HasColumnType("TEXT(100)")
                    .HasColumnName("FACT_NAME");

                entity.Property(e => e.FactSeqNum).HasColumnName("FACT_SEQ_NUM");

                entity.Property(e => e.FactType)
                    .HasColumnType("TEXT(20)")
                    .HasColumnName("FACT_TYPE");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");
            });

            modelBuilder.Entity<Factval>(entity =>
            {
                entity.ToTable("FACTVAL");

                entity.Property(e => e.FactValId)
                    .ValueGeneratedNever()
                    .HasColumnName("FACT_VAL_ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.FactId).HasColumnName("FACT_ID");

                entity.Property(e => e.FactValue)
                    .HasColumnType("TEXT(24)")
                    .HasColumnName("FACT_VALUE");

                entity.Property(e => e.FactValueDescr)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("FACT_VALUE_DESCR");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");
            });

            modelBuilder.Entity<Filtprop>(entity =>
            {
                entity.HasKey(e => e.FilterId);

                entity.ToTable("FILTPROP");

                entity.Property(e => e.FilterId)
                    .ValueGeneratedNever()
                    .HasColumnName("FILTER_ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.FilterData).HasColumnName("FILTER_DATA");

                entity.Property(e => e.FilterName)
                    .HasColumnType("TEXT(40)")
                    .HasColumnName("FILTER_NAME");

                entity.Property(e => e.FilterType)
                    .HasColumnType("TEXT(20)")
                    .HasColumnName("FILTER_TYPE");

                entity.Property(e => e.RptId).HasColumnName("RPT_ID");

                entity.Property(e => e.TableName)
                    .HasColumnType("TEXT(16)")
                    .HasColumnName("TABLE_NAME");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.UserId).HasColumnName("USER_ID");
            });

            modelBuilder.Entity<Findate>(entity =>
            {
                entity.HasKey(e => e.FinDatesId);

                entity.ToTable("FINDATES");

                entity.Property(e => e.FinDatesId)
                    .ValueGeneratedNever()
                    .HasColumnName("FIN_DATES_ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.EndDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("END_DATE");

                entity.Property(e => e.FinDatesName)
                    .HasColumnType("TEXT(60)")
                    .HasColumnName("FIN_DATES_NAME");

                entity.Property(e => e.FintmplId)
                    .HasColumnType("NUMBER(10)")
                    .HasColumnName("FINTMPL_ID");

                entity.Property(e => e.StartDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("START_DATE");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.HasOne(d => d.Fintmpl)
                    .WithMany(p => p.Findates)
                    .HasForeignKey(d => d.FintmplId);
            });

            modelBuilder.Entity<Fintmpl>(entity =>
            {
                entity.ToTable("FINTMPL");

                entity.Property(e => e.FintmplId)
                    .HasColumnType("NUMBER(10)")
                    .HasColumnName("FINTMPL_ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.DefaultFlag)
                    .HasColumnType("CHAR(1)")
                    .HasColumnName("DEFAULT_FLAG");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATE")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId)
                    .HasColumnType("NUMBER(10)")
                    .HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.FintmplName)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("FINTMPL_NAME");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");
            });

            modelBuilder.Entity<Fundsrc>(entity =>
            {
                entity.HasKey(e => e.FundId);

                entity.ToTable("FUNDSRC");

                entity.Property(e => e.FundId)
                    .ValueGeneratedNever()
                    .HasColumnName("FUND_ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.FundDescr).HasColumnName("FUND_DESCR");

                entity.Property(e => e.FundName)
                    .HasColumnType("TEXT(100)")
                    .HasColumnName("FUND_NAME");

                entity.Property(e => e.ParentFundId).HasColumnName("PARENT_FUND_ID");

                entity.Property(e => e.SeqNum).HasColumnName("SEQ_NUM");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");
            });

            modelBuilder.Entity<Gchange>(entity =>
            {
                entity.ToTable("GCHANGE");

                entity.Property(e => e.GchangeId)
                    .ValueGeneratedNever()
                    .HasColumnName("GCHANGE_ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.GchangeData).HasColumnName("GCHANGE_DATA");

                entity.Property(e => e.GchangeName)
                    .HasColumnType("TEXT(40)")
                    .HasColumnName("GCHANGE_NAME");

                entity.Property(e => e.TableName)
                    .HasColumnType("TEXT(20)")
                    .HasColumnName("TABLE_NAME");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.UserId).HasColumnName("USER_ID");
            });

            modelBuilder.Entity<Imagedatum>(entity =>
            {
                entity.HasKey(e => e.ImageId);

                entity.ToTable("IMAGEDATA");

                entity.HasIndex(e => e.ImageName, "IX_IMAGEDATA_IMAGE_NAME")
                    .IsUnique();

                entity.Property(e => e.ImageId)
                    .ValueGeneratedNever()
                    .HasColumnName("IMAGE_ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.DefaultFlag)
                    .HasColumnType("TEXT(1)")
                    .HasColumnName("DEFAULT_FLAG");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.ImageData).HasColumnName("IMAGE_DATA");

                entity.Property(e => e.ImageDescription)
                    .HasColumnType("TEXT(250)")
                    .HasColumnName("IMAGE_DESCRIPTION");

                entity.Property(e => e.ImageExtension)
                    .HasColumnType("TEXT(20)")
                    .HasColumnName("IMAGE_EXTENSION")
                    .HasDefaultValueSql("'png'");

                entity.Property(e => e.ImageName)
                    .HasColumnType("TEXT(120)")
                    .HasColumnName("IMAGE_NAME");

                entity.Property(e => e.ImagePurpose)
                    .HasColumnType("TEXT(50)")
                    .HasColumnName("IMAGE_PURPOSE");

                entity.Property(e => e.ImageThumbnail).HasColumnName("IMAGE_THUMBNAIL");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");
            });

            modelBuilder.Entity<Issuhist>(entity =>
            {
                entity.HasKey(e => e.IssueId);

                entity.ToTable("ISSUHIST");

                entity.HasIndex(e => e.ProjId, "ndx_issuhist_proj_id");

                entity.Property(e => e.IssueId)
                    .ValueGeneratedNever()
                    .HasColumnName("ISSUE_ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.IssueHistory).HasColumnName("ISSUE_HISTORY");

                entity.Property(e => e.ProjId).HasColumnName("PROJ_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");
            });

            modelBuilder.Entity<Jobsvc>(entity =>
            {
                entity.HasKey(e => e.JobId);

                entity.ToTable("JOBSVC");

                entity.Property(e => e.JobId)
                    .ValueGeneratedNever()
                    .HasColumnName("JOB_ID");

                entity.Property(e => e.AuditFilePath)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("AUDIT_FILE_PATH");

                entity.Property(e => e.AuditFlag)
                    .HasColumnType("TEXT(1)")
                    .HasColumnName("AUDIT_FLAG");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.JobData).HasColumnName("JOB_DATA");

                entity.Property(e => e.JobName)
                    .HasColumnType("TEXT(100)")
                    .HasColumnName("JOB_NAME");

                entity.Property(e => e.JobType)
                    .HasColumnType("TEXT(20)")
                    .HasColumnName("JOB_TYPE");

                entity.Property(e => e.LastErrorDescr)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("LAST_ERROR_DESCR");

                entity.Property(e => e.LastRunDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("LAST_RUN_DATE");

                entity.Property(e => e.ParentJobId).HasColumnName("PARENT_JOB_ID");

                entity.Property(e => e.RecurData)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("RECUR_DATA");

                entity.Property(e => e.RecurType)
                    .HasColumnType("TEXT(20)")
                    .HasColumnName("RECUR_TYPE");

                entity.Property(e => e.SeqNum).HasColumnName("SEQ_NUM");

                entity.Property(e => e.StatusCode)
                    .HasColumnType("TEXT(20)")
                    .HasColumnName("STATUS_CODE");

                entity.Property(e => e.SubmittedDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("SUBMITTED_DATE");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.UserId).HasColumnName("USER_ID");
            });

            modelBuilder.Entity<Location>(entity =>
            {
                entity.ToTable("LOCATION");

                entity.Property(e => e.LocationId)
                    .ValueGeneratedNever()
                    .HasColumnName("LOCATION_ID");

                entity.Property(e => e.AddressLine1)
                    .HasColumnType("TEXT(200)")
                    .HasColumnName("ADDRESS_LINE1");

                entity.Property(e => e.AddressLine2)
                    .HasColumnType("TEXT(200)")
                    .HasColumnName("ADDRESS_LINE2");

                entity.Property(e => e.AddressLine3)
                    .HasColumnType("TEXT(200)")
                    .HasColumnName("ADDRESS_LINE3");

                entity.Property(e => e.CityName)
                    .HasColumnType("TEXT(200)")
                    .HasColumnName("CITY_NAME");

                entity.Property(e => e.CountryCode)
                    .HasColumnType("TEXT(3)")
                    .HasColumnName("COUNTRY_CODE");

                entity.Property(e => e.CountryName)
                    .HasColumnType("TEXT(200)")
                    .HasColumnName("COUNTRY_NAME");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.Latitude).HasColumnName("LATITUDE");

                entity.Property(e => e.LocationName)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("LOCATION_NAME");

                entity.Property(e => e.LocationType)
                    .HasColumnType("TEXT(24)")
                    .HasColumnName("LOCATION_TYPE");

                entity.Property(e => e.Longitude).HasColumnName("LONGITUDE");

                entity.Property(e => e.MunicipalityName)
                    .HasColumnType("TEXT(200)")
                    .HasColumnName("MUNICIPALITY_NAME");

                entity.Property(e => e.PostalCode)
                    .HasColumnType("TEXT(20)")
                    .HasColumnName("POSTAL_CODE");

                entity.Property(e => e.StateCode)
                    .HasColumnType("TEXT(2)")
                    .HasColumnName("STATE_CODE");

                entity.Property(e => e.StateName)
                    .HasColumnType("TEXT(200)")
                    .HasColumnName("STATE_NAME");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");
            });

            modelBuilder.Entity<Memotype>(entity =>
            {
                entity.ToTable("MEMOTYPE");

                entity.Property(e => e.MemoTypeId)
                    .ValueGeneratedNever()
                    .HasColumnName("MEMO_TYPE_ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.EpsFlag)
                    .HasColumnType("TEXT(1)")
                    .HasColumnName("EPS_FLAG");

                entity.Property(e => e.MemoType1)
                    .HasColumnType("TEXT(40)")
                    .HasColumnName("MEMO_TYPE");

                entity.Property(e => e.ProjFlag)
                    .HasColumnType("TEXT(1)")
                    .HasColumnName("PROJ_FLAG");

                entity.Property(e => e.SeqNum).HasColumnName("SEQ_NUM");

                entity.Property(e => e.TaskFlag)
                    .HasColumnType("TEXT(1)")
                    .HasColumnName("TASK_FLAG");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.WbsFlag)
                    .HasColumnType("TEXT(1)")
                    .HasColumnName("WBS_FLAG");
            });

            modelBuilder.Entity<Nextkey>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NEXTKEY");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.KeyName)
                    .HasColumnType("TEXT(30)")
                    .HasColumnName("KEY_NAME");

                entity.Property(e => e.KeySeqNum).HasColumnName("KEY_SEQ_NUM");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");
            });

            modelBuilder.Entity<Ob>(entity =>
            {
                entity.HasKey(e => e.ObsId);

                entity.ToTable("OBS");

                entity.Property(e => e.ObsId)
                    .ValueGeneratedNever()
                    .HasColumnName("OBS_ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.Guid)
                    .HasColumnType("TEXT(22)")
                    .HasColumnName("GUID");

                entity.Property(e => e.ObsDescr).HasColumnName("OBS_DESCR");

                entity.Property(e => e.ObsName)
                    .HasColumnType("TEXT(100)")
                    .HasColumnName("OBS_NAME");

                entity.Property(e => e.ParentObsId).HasColumnName("PARENT_OBS_ID");

                entity.Property(e => e.SeqNum).HasColumnName("SEQ_NUM");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");
            });

            modelBuilder.Entity<OpeningAccount>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("OPENING_ACCOUNT");

                entity.Property(e => e.AcctId).HasColumnName("ACCT_ID");
            });

            modelBuilder.Entity<OpeningActvcode>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("OPENING_ACTVCODE");

                entity.Property(e => e.ActvCodeId).HasColumnName("ACTV_CODE_ID");

                entity.Property(e => e.ParentActvCodeId).HasColumnName("PARENT_ACTV_CODE_ID");
            });

            modelBuilder.Entity<OpeningOb>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("OPENING_OBS");

                entity.Property(e => e.ObsId).HasColumnName("OBS_ID");
            });

            modelBuilder.Entity<OpeningRole>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("OPENING_ROLE");

                entity.Property(e => e.RoleId).HasColumnName("ROLE_ID");
            });

            modelBuilder.Entity<OpeningRsrc>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("OPENING_RSRC");

                entity.Property(e => e.RsrcId).HasColumnName("RSRC_ID");
            });

            modelBuilder.Entity<OpeningRsrcrole>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("OPENING_RSRCROLE");

                entity.Property(e => e.RoleId).HasColumnName("ROLE_ID");

                entity.Property(e => e.RsrcId).HasColumnName("RSRC_ID");
            });

            modelBuilder.Entity<OpeningUser>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("OPENING_USERS");

                entity.Property(e => e.UserId).HasColumnName("USER_ID");
            });

            modelBuilder.Entity<Pcattype>(entity =>
            {
                entity.HasKey(e => e.ProjCatgTypeId);

                entity.ToTable("PCATTYPE");

                entity.Property(e => e.ProjCatgTypeId)
                    .ValueGeneratedNever()
                    .HasColumnName("PROJ_CATG_TYPE_ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.ProjCatgShortLen).HasColumnName("PROJ_CATG_SHORT_LEN");

                entity.Property(e => e.ProjCatgType)
                    .HasColumnType("TEXT(60)")
                    .HasColumnName("PROJ_CATG_TYPE");

                entity.Property(e => e.SeqNum).HasColumnName("SEQ_NUM");

                entity.Property(e => e.SuperFlag)
                    .HasColumnType("TEXT(1)")
                    .HasColumnName("SUPER_FLAG");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");
            });

            modelBuilder.Entity<Pcatval>(entity =>
            {
                entity.HasKey(e => e.ProjCatgId);

                entity.ToTable("PCATVAL");

                entity.Property(e => e.ProjCatgId)
                    .ValueGeneratedNever()
                    .HasColumnName("PROJ_CATG_ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.ParentProjCatgId).HasColumnName("PARENT_PROJ_CATG_ID");

                entity.Property(e => e.ProjCatgName)
                    .HasColumnType("TEXT(100)")
                    .HasColumnName("PROJ_CATG_NAME");

                entity.Property(e => e.ProjCatgShortName)
                    .HasColumnType("TEXT(60)")
                    .HasColumnName("PROJ_CATG_SHORT_NAME");

                entity.Property(e => e.ProjCatgTypeId).HasColumnName("PROJ_CATG_TYPE_ID");

                entity.Property(e => e.SeqNum).HasColumnName("SEQ_NUM");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");
            });

            modelBuilder.Entity<PfloadView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PFLOAD_VIEW");

                entity.Property(e => e.PfolioId).HasColumnName("PFOLIO_ID");

                entity.Property(e => e.ProjId).HasColumnName("PROJ_ID");

                entity.Property(e => e.WbsId).HasColumnName("WBS_ID");
            });

            modelBuilder.Entity<Pfolio>(entity =>
            {
                entity.ToTable("PFOLIO");

                entity.Property(e => e.PfolioId)
                    .ValueGeneratedNever()
                    .HasColumnName("PFOLIO_ID");

                entity.Property(e => e.ClosedProjFlag)
                    .HasColumnType("TEXT(1)")
                    .HasColumnName("CLOSED_PROJ_FLAG");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.PfolioData).HasColumnName("PFOLIO_DATA");

                entity.Property(e => e.PfolioDescr)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("PFOLIO_DESCR");

                entity.Property(e => e.PfolioName)
                    .HasColumnType("TEXT(40)")
                    .HasColumnName("PFOLIO_NAME");

                entity.Property(e => e.PfolioType)
                    .HasColumnType("TEXT(20)")
                    .HasColumnName("PFOLIO_TYPE");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.UserId).HasColumnName("USER_ID");

                entity.Property(e => e.WhatifProjFlag)
                    .HasColumnType("TEXT(1)")
                    .HasColumnName("WHATIF_PROJ_FLAG");
            });

            modelBuilder.Entity<Phase>(entity =>
            {
                entity.ToTable("PHASE");

                entity.Property(e => e.PhaseId)
                    .ValueGeneratedNever()
                    .HasColumnName("PHASE_ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.PhaseName)
                    .HasColumnType("TEXT(100)")
                    .HasColumnName("PHASE_NAME");

                entity.Property(e => e.SeqNum).HasColumnName("SEQ_NUM");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");
            });

            modelBuilder.Entity<Pkxref>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PKXREF");

                entity.Property(e => e.AddDate)
                    .HasColumnType("DateTime")
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.ContextName)
                    .HasColumnType("TEXT(30)")
                    .HasColumnName("CONTEXT_NAME");

                entity.Property(e => e.NewStr)
                    .HasColumnType("TEXT(40)")
                    .HasColumnName("NEW_STR");

                entity.Property(e => e.OldPk1).HasColumnName("OLD_PK1");

                entity.Property(e => e.OldPk2).HasColumnName("OLD_PK2");

                entity.Property(e => e.OldStr)
                    .HasColumnType("TEXT(40)")
                    .HasColumnName("OLD_STR");

                entity.Property(e => e.Pk1).HasColumnName("PK1");

                entity.Property(e => e.Pk2).HasColumnName("PK2");

                entity.Property(e => e.SystemId).HasColumnName("SYSTEM_ID");
            });

            modelBuilder.Entity<Pob>(entity =>
            {
                entity.HasKey(e => e.PobsId);

                entity.ToTable("POBS");

                entity.Property(e => e.PobsId)
                    .ValueGeneratedNever()
                    .HasColumnName("POBS_ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.PobsDescr)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("POBS_DESCR");

                entity.Property(e => e.PobsManager)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("POBS_MANAGER");

                entity.Property(e => e.PobsName)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("POBS_NAME");

                entity.Property(e => e.PobsParentId).HasColumnName("POBS_PARENT_ID");

                entity.Property(e => e.SeqNum).HasColumnName("SEQ_NUM");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");
            });

            modelBuilder.Entity<Prefer>(entity =>
            {
                entity.ToTable("PREFER");

                entity.Property(e => e.PreferId)
                    .ValueGeneratedNever()
                    .HasColumnName("PREFER_ID");

                entity.Property(e => e.AcctShortLen).HasColumnName("ACCT_SHORT_LEN");

                entity.Property(e => e.AllowUserTimePeriodFlag)
                    .HasColumnType("TEXT(1)")
                    .HasColumnName("ALLOW_USER_TIME_PERIOD_FLAG");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.CurrId).HasColumnName("CURR_ID");

                entity.Property(e => e.DatabaseVersion)
                    .HasColumnType("TEXT(30)")
                    .HasColumnName("DATABASE_VERSION");

                entity.Property(e => e.DayChar)
                    .HasColumnType("TEXT(4)")
                    .HasColumnName("DAY_CHAR");

                entity.Property(e => e.DayHrCnt).HasColumnName("DAY_HR_CNT");

                entity.Property(e => e.DbName)
                    .HasColumnType("TEXT(20)")
                    .HasColumnName("DB_NAME");

                entity.Property(e => e.DefTargetDrtnHrCnt).HasColumnName("DEF_TARGET_DRTN_HR_CNT");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.EvComputeType)
                    .HasColumnType("TEXT(20)")
                    .HasColumnName("EV_COMPUTE_TYPE");

                entity.Property(e => e.EvEtcComputeType)
                    .HasColumnType("TEXT(20)")
                    .HasColumnName("EV_ETC_COMPUTE_TYPE");

                entity.Property(e => e.EvEtcUserValue).HasColumnName("EV_ETC_USER_VALUE");

                entity.Property(e => e.EvFixCostFlag)
                    .HasColumnType("TEXT(1)")
                    .HasColumnName("EV_FIX_COST_FLAG");

                entity.Property(e => e.EvUserPct).HasColumnName("EV_USER_PCT");

                entity.Property(e => e.ExpRootUrl)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("EXP_ROOT_URL");

                entity.Property(e => e.HourChar)
                    .HasColumnType("TEXT(4)")
                    .HasColumnName("HOUR_CHAR");

                entity.Property(e => e.LicenseData)
                    .HasColumnType("TEXT(0)")
                    .HasColumnName("LICENSE_DATA");

                entity.Property(e => e.MaxAcctLevelCnt).HasColumnName("MAX_ACCT_LEVEL_CNT");

                entity.Property(e => e.MaxActvLevelCnt).HasColumnName("MAX_ACTV_LEVEL_CNT");

                entity.Property(e => e.MaxBaseCnt).HasColumnName("MAX_BASE_CNT");

                entity.Property(e => e.MaxEpsLevelCnt).HasColumnName("MAX_EPS_LEVEL_CNT");

                entity.Property(e => e.MaxObsLevelCnt).HasColumnName("MAX_OBS_LEVEL_CNT");

                entity.Property(e => e.MaxPcatLevelCnt).HasColumnName("MAX_PCAT_LEVEL_CNT");

                entity.Property(e => e.MaxRcatLevelCnt).HasColumnName("MAX_RCAT_LEVEL_CNT");

                entity.Property(e => e.MaxRoleLevelCnt).HasColumnName("MAX_ROLE_LEVEL_CNT");

                entity.Property(e => e.MaxRsrcLevelCnt).HasColumnName("MAX_RSRC_LEVEL_CNT");

                entity.Property(e => e.MaxTaskActvTypeCnt).HasColumnName("MAX_TASK_ACTV_TYPE_CNT");

                entity.Property(e => e.MaxWbsLevelCnt).HasColumnName("MAX_WBS_LEVEL_CNT");

                entity.Property(e => e.MinuteChar)
                    .HasColumnType("TEXT(4)")
                    .HasColumnName("MINUTE_CHAR");

                entity.Property(e => e.MonthChar)
                    .HasColumnType("TEXT(4)")
                    .HasColumnName("MONTH_CHAR");

                entity.Property(e => e.MonthHrCnt).HasColumnName("MONTH_HR_CNT");

                entity.Property(e => e.NameSepChar)
                    .HasColumnType("TEXT(2)")
                    .HasColumnName("NAME_SEP_CHAR");

                entity.Property(e => e.PhaseLabel)
                    .HasColumnType("TEXT(40)")
                    .HasColumnName("PHASE_LABEL");

                entity.Property(e => e.ProjShortLen).HasColumnName("PROJ_SHORT_LEN");

                entity.Property(e => e.RoleShortLen).HasColumnName("ROLE_SHORT_LEN");

                entity.Property(e => e.RptFooter1)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("RPT_FOOTER_1");

                entity.Property(e => e.RptFooter2)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("RPT_FOOTER_2");

                entity.Property(e => e.RptFooter3)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("RPT_FOOTER_3");

                entity.Property(e => e.RptHeader1)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("RPT_HEADER_1");

                entity.Property(e => e.RptHeader2)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("RPT_HEADER_2");

                entity.Property(e => e.RptHeader3)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("RPT_HEADER_3");

                entity.Property(e => e.RptUser1)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("RPT_USER_1");

                entity.Property(e => e.RptUser2)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("RPT_USER_2");

                entity.Property(e => e.RptUser3)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("RPT_USER_3");

                entity.Property(e => e.RsrcShortLen).HasColumnName("RSRC_SHORT_LEN");

                entity.Property(e => e.TaskCodeLen).HasColumnName("TASK_CODE_LEN");

                entity.Property(e => e.TasksumPeriodType)
                    .HasColumnType("TEXT(20)")
                    .HasColumnName("TASKSUM_PERIOD_TYPE");

                entity.Property(e => e.TrsrcsumPeriodType)
                    .HasColumnType("TEXT(20)")
                    .HasColumnName("TRSRCSUM_PERIOD_TYPE");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.WbsShortLen).HasColumnName("WBS_SHORT_LEN");

                entity.Property(e => e.WeekChar)
                    .HasColumnType("TEXT(4)")
                    .HasColumnName("WEEK_CHAR");

                entity.Property(e => e.WeekHrCnt).HasColumnName("WEEK_HR_CNT");

                entity.Property(e => e.WeekStartDayNum).HasColumnName("WEEK_START_DAY_NUM");

                entity.Property(e => e.YearChar)
                    .HasColumnType("TEXT(4)")
                    .HasColumnName("YEAR_CHAR");

                entity.Property(e => e.YearHrCnt).HasColumnName("YEAR_HR_CNT");
            });

            modelBuilder.Entity<Procgroup>(entity =>
            {
                entity.ToTable("PROCGROUP");

                entity.Property(e => e.ProcGroupId)
                    .ValueGeneratedNever()
                    .HasColumnName("PROC_GROUP_ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.ProcGroupName)
                    .HasColumnType("TEXT(120)")
                    .HasColumnName("PROC_GROUP_NAME");

                entity.Property(e => e.SeqNum).HasColumnName("SEQ_NUM");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");
            });

            modelBuilder.Entity<Procitem>(entity =>
            {
                entity.ToTable("PROCITEM");

                entity.Property(e => e.ProcItemId)
                    .ValueGeneratedNever()
                    .HasColumnName("PROC_ITEM_ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.ProcDescr).HasColumnName("PROC_DESCR");

                entity.Property(e => e.ProcGroupId).HasColumnName("PROC_GROUP_ID");

                entity.Property(e => e.ProcName)
                    .HasColumnType("TEXT(120)")
                    .HasColumnName("PROC_NAME");

                entity.Property(e => e.ProcWt).HasColumnName("PROC_WT");

                entity.Property(e => e.SeqNum).HasColumnName("SEQ_NUM");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");
            });

            modelBuilder.Entity<Profile>(entity =>
            {
                entity.HasKey(e => e.ProfId);

                entity.ToTable("PROFILE");

                entity.Property(e => e.ProfId)
                    .ValueGeneratedNever()
                    .HasColumnName("PROF_ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.DefaultFlag)
                    .HasColumnType("TEXT(1)")
                    .HasColumnName("DEFAULT_FLAG");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.ProfName)
                    .HasColumnType("TEXT(100)")
                    .HasColumnName("PROF_NAME");

                entity.Property(e => e.ScopeType)
                    .HasColumnType("TEXT(12)")
                    .HasColumnName("SCOPE_TYPE");

                entity.Property(e => e.SuperuserFlag)
                    .HasColumnType("TEXT(1)")
                    .HasColumnName("SUPERUSER_FLAG");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");
            });

            modelBuilder.Entity<Profpriv>(entity =>
            {
                entity.HasKey(e => new { e.ProfId, e.PrivNum });

                entity.ToTable("PROFPRIV");

                entity.Property(e => e.ProfId).HasColumnName("PROF_ID");

                entity.Property(e => e.PrivNum).HasColumnName("PRIV_NUM");

                entity.Property(e => e.AllowFlag)
                    .HasColumnType("TEXT(1)")
                    .HasColumnName("ALLOW_FLAG");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");
            });

            modelBuilder.Entity<Projcost>(entity =>
            {
                entity.HasKey(e => e.CostItemId);

                entity.ToTable("PROJCOST");

                entity.HasIndex(e => e.ProjId, "ndx_projcost_proj_id");

                entity.Property(e => e.CostItemId)
                    .ValueGeneratedNever()
                    .HasColumnName("COST_ITEM_ID");

                entity.Property(e => e.AcctId).HasColumnName("ACCT_ID");

                entity.Property(e => e.ActCost).HasColumnName("ACT_COST");

                entity.Property(e => e.AutoComputeActFlag)
                    .HasColumnType("TEXT(1)")
                    .HasColumnName("AUTO_COMPUTE_ACT_FLAG");

                entity.Property(e => e.CostDescr).HasColumnName("COST_DESCR");

                entity.Property(e => e.CostLoadType)
                    .HasColumnType("TEXT(12)")
                    .HasColumnName("COST_LOAD_TYPE");

                entity.Property(e => e.CostName)
                    .HasColumnType("TEXT(120)")
                    .HasColumnName("COST_NAME");

                entity.Property(e => e.CostPerQty).HasColumnName("COST_PER_QTY");

                entity.Property(e => e.CostTypeId).HasColumnName("COST_TYPE_ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.PoNumber)
                    .HasColumnType("TEXT(32)")
                    .HasColumnName("PO_NUMBER");

                entity.Property(e => e.PobsId).HasColumnName("POBS_ID");

                entity.Property(e => e.ProjId).HasColumnName("PROJ_ID");

                entity.Property(e => e.QtyName)
                    .HasColumnType("TEXT(30)")
                    .HasColumnName("QTY_NAME");

                entity.Property(e => e.RemainCost).HasColumnName("REMAIN_COST");

                entity.Property(e => e.TargetCost).HasColumnName("TARGET_COST");

                entity.Property(e => e.TargetQty).HasColumnName("TARGET_QTY");

                entity.Property(e => e.TaskId).HasColumnName("TASK_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.VendorName)
                    .HasColumnType("TEXT(100)")
                    .HasColumnName("VENDOR_NAME");
            });

            modelBuilder.Entity<Project>(entity =>
            {
                entity.HasKey(e => e.ProjId);

                entity.ToTable("PROJECT");

                entity.Property(e => e.ProjId)
                    .ValueGeneratedNever()
                    .HasColumnName("PROJ_ID");

                entity.Property(e => e.AcctId).HasColumnName("ACCT_ID");

                entity.Property(e => e.ActPctLinkFlag)
                    .HasColumnType("TEXT(1)")
                    .HasColumnName("ACT_PCT_LINK_FLAG");

                entity.Property(e => e.ActThisPerLinkFlag)
                    .HasColumnType("TEXT(1)")
                    .HasColumnName("ACT_THIS_PER_LINK_FLAG");

                entity.Property(e => e.AddActRemainFlag)
                    .HasColumnType("TEXT(1)")
                    .HasColumnName("ADD_ACT_REMAIN_FLAG");

                entity.Property(e => e.AddByName)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("ADD_BY_NAME");

                entity.Property(e => e.AddDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.AllowCompleteFlag)
                    .HasColumnType("TEXT(1)")
                    .HasColumnName("ALLOW_COMPLETE_FLAG");

                entity.Property(e => e.AllowNegActFlag)
                    .HasColumnType("TEXT(1)")
                    .HasColumnName("ALLOW_NEG_ACT_FLAG");

                entity.Property(e => e.ApplyActualsDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("APPLY_ACTUALS_DATE");

                entity.Property(e => e.BaseTypeId).HasColumnName("BASE_TYPE_ID");

                entity.Property(e => e.BatchSumFlag)
                    .HasColumnType("TEXT(1)")
                    .HasColumnName("BATCH_SUM_FLAG");

                entity.Property(e => e.CheckoutDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CHECKOUT_DATE");

                entity.Property(e => e.CheckoutFlag)
                    .HasColumnType("TEXT(1)")
                    .HasColumnName("CHECKOUT_FLAG");

                entity.Property(e => e.CheckoutUserId).HasColumnName("CHECKOUT_USER_ID");

                entity.Property(e => e.ClndrId).HasColumnName("CLNDR_ID");

                entity.Property(e => e.ControlUpdatesFlag)
                    .HasColumnType("TEXT(1)")
                    .HasColumnName("CONTROL_UPDATES_FLAG")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.CostQtyRecalcFlag)
                    .HasColumnType("TEXT(1)")
                    .HasColumnName("COST_QTY_RECALC_FLAG");

                entity.Property(e => e.CrExternalKey)
                    .HasColumnType("TEXT(4000)")
                    .HasColumnName("CR_EXTERNAL_KEY");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.CriticalDrtnHrCnt).HasColumnName("CRITICAL_DRTN_HR_CNT");

                entity.Property(e => e.CriticalPathType)
                    .HasColumnType("TEXT(12)")
                    .HasColumnName("CRITICAL_PATH_TYPE");

                entity.Property(e => e.DefCompletePctType)
                    .HasColumnType("TEXT(10)")
                    .HasColumnName("DEF_COMPLETE_PCT_TYPE");

                entity.Property(e => e.DefCostPerQty).HasColumnName("DEF_COST_PER_QTY");

                entity.Property(e => e.DefDurationType)
                    .HasColumnType("TEXT(12)")
                    .HasColumnName("DEF_DURATION_TYPE");

                entity.Property(e => e.DefQtyType)
                    .HasColumnType("TEXT(24)")
                    .HasColumnName("DEF_QTY_TYPE");

                entity.Property(e => e.DefRateType)
                    .HasColumnType("TEXT(14)")
                    .HasColumnName("DEF_RATE_TYPE");

                entity.Property(e => e.DefRollupDatesFlag)
                    .HasColumnType("TEXT(1)")
                    .HasColumnName("DEF_ROLLUP_DATES_FLAG");

                entity.Property(e => e.DefTaskType)
                    .HasColumnType("TEXT(12)")
                    .HasColumnName("DEF_TASK_TYPE");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.FcstStartDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("FCST_START_DATE");

                entity.Property(e => e.FintmplId)
                    .HasColumnType("NUMBER(10)")
                    .HasColumnName("FINTMPL_ID");

                entity.Property(e => e.FyStartMonthNum).HasColumnName("FY_START_MONTH_NUM");

                entity.Property(e => e.Guid)
                    .HasColumnType("TEXT(22)")
                    .HasColumnName("GUID");

                entity.Property(e => e.LastBaselineUpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("LAST_BASELINE_UPDATE_DATE");

                entity.Property(e => e.LastChecksum).HasColumnName("LAST_CHECKSUM");

                entity.Property(e => e.LastFinDatesId).HasColumnName("LAST_FIN_DATES_ID");

                entity.Property(e => e.LastRecalcDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("LAST_RECALC_DATE");

                entity.Property(e => e.LastTasksumDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("LAST_TASKSUM_DATE");

                entity.Property(e => e.LocationId).HasColumnName("LOCATION_ID");

                entity.Property(e => e.NameSepChar)
                    .HasColumnType("TEXT(2)")
                    .HasColumnName("NAME_SEP_CHAR");

                entity.Property(e => e.OrigProjId).HasColumnName("ORIG_PROJ_ID");

                entity.Property(e => e.PlanEndDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("PLAN_END_DATE");

                entity.Property(e => e.PlanStartDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("PLAN_START_DATE");

                entity.Property(e => e.PriorityNum).HasColumnName("PRIORITY_NUM");

                entity.Property(e => e.ProjShortName)
                    .HasColumnType("TEXT(40)")
                    .HasColumnName("PROJ_SHORT_NAME");

                entity.Property(e => e.ProjUrl)
                    .HasColumnType("TEXT(200)")
                    .HasColumnName("PROJ_URL");

                entity.Property(e => e.ProjectFlag)
                    .HasColumnType("TEXT(1)")
                    .HasColumnName("PROJECT_FLAG");

                entity.Property(e => e.RemTargetLinkFlag)
                    .HasColumnType("TEXT(1)")
                    .HasColumnName("REM_TARGET_LINK_FLAG");

                entity.Property(e => e.ResetPlannedFlag)
                    .HasColumnType("TEXT(1)")
                    .HasColumnName("RESET_PLANNED_FLAG");

                entity.Property(e => e.RsrcMultiAssignFlag)
                    .HasColumnType("TEXT(1)")
                    .HasColumnName("RSRC_MULTI_ASSIGN_FLAG");

                entity.Property(e => e.RsrcSelfAddFlag)
                    .HasColumnType("TEXT(1)")
                    .HasColumnName("RSRC_SELF_ADD_FLAG");

                entity.Property(e => e.ScdEndDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("SCD_END_DATE");

                entity.Property(e => e.SourceProjId).HasColumnName("SOURCE_PROJ_ID");

                entity.Property(e => e.StepCompleteFlag)
                    .HasColumnType("TEXT(1)")
                    .HasColumnName("STEP_COMPLETE_FLAG");

                entity.Property(e => e.StrgyPriorityNum).HasColumnName("STRGY_PRIORITY_NUM");

                entity.Property(e => e.SumAssignLevel)
                    .HasColumnType("TEXT(12)")
                    .HasColumnName("SUM_ASSIGN_LEVEL");

                entity.Property(e => e.SumBaseProjId).HasColumnName("SUM_BASE_PROJ_ID");

                entity.Property(e => e.TaskCodeBase).HasColumnName("TASK_CODE_BASE");

                entity.Property(e => e.TaskCodePrefix)
                    .HasColumnType("TEXT(20)")
                    .HasColumnName("TASK_CODE_PREFIX");

                entity.Property(e => e.TaskCodePrefixFlag)
                    .HasColumnType("TEXT(1)")
                    .HasColumnName("TASK_CODE_PREFIX_FLAG");

                entity.Property(e => e.TaskCodeStep).HasColumnName("TASK_CODE_STEP");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.UseProjectBaselineFlag)
                    .HasColumnType("TEXT(1)")
                    .HasColumnName("USE_PROJECT_BASELINE_FLAG");

                entity.Property(e => e.WbsMaxSumLevel).HasColumnName("WBS_MAX_SUM_LEVEL");

                entity.Property(e => e.WebLocalRootPath)
                    .HasColumnType("TEXT(120)")
                    .HasColumnName("WEB_LOCAL_ROOT_PATH");

                entity.HasOne(d => d.Fintmpl)
                    .WithMany(p => p.Projects)
                    .HasForeignKey(d => d.FintmplId);
            });

            modelBuilder.Entity<Projest>(entity =>
            {
                entity.ToTable("PROJEST");

                entity.HasIndex(e => e.ProjId, "ndx_projest_proj_id");

                entity.Property(e => e.ProjEstId)
                    .ValueGeneratedNever()
                    .HasColumnName("PROJ_EST_ID");

                entity.Property(e => e.AdjMultPct).HasColumnName("ADJ_MULT_PCT");

                entity.Property(e => e.AppliedFlag)
                    .HasColumnType("TEXT(1)")
                    .HasColumnName("APPLIED_FLAG");

                entity.Property(e => e.BuCmplxValue).HasColumnName("BU_CMPLX_VALUE");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.EstDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("EST_DATE");

                entity.Property(e => e.EstName)
                    .HasColumnType("TEXT(120)")
                    .HasColumnName("EST_NAME");

                entity.Property(e => e.EstNotes).HasColumnName("EST_NOTES");

                entity.Property(e => e.EstQty).HasColumnName("EST_QTY");

                entity.Property(e => e.EstTaskCnt).HasColumnName("EST_TASK_CNT");

                entity.Property(e => e.EstType)
                    .HasColumnType("TEXT(20)")
                    .HasColumnName("EST_TYPE");

                entity.Property(e => e.FpCmplxValue).HasColumnName("FP_CMPLX_VALUE");

                entity.Property(e => e.FpCnt).HasColumnName("FP_CNT");

                entity.Property(e => e.FpProdAvgValue).HasColumnName("FP_PROD_AVG_VALUE");

                entity.Property(e => e.FpUnadjCnt).HasColumnName("FP_UNADJ_CNT");

                entity.Property(e => e.ProjId).HasColumnName("PROJ_ID");

                entity.Property(e => e.RsrcId).HasColumnName("RSRC_ID");

                entity.Property(e => e.RsrcType)
                    .HasColumnType("TEXT(10)")
                    .HasColumnName("RSRC_TYPE");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.WbsId).HasColumnName("WBS_ID");
            });

            modelBuilder.Entity<Projfund>(entity =>
            {
                entity.ToTable("PROJFUND");

                entity.HasIndex(e => e.ProjId, "ndx_projfund_proj_id");

                entity.Property(e => e.ProjFundId)
                    .ValueGeneratedNever()
                    .HasColumnName("PROJ_FUND_ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.FundCost).HasColumnName("FUND_COST");

                entity.Property(e => e.FundId).HasColumnName("FUND_ID");

                entity.Property(e => e.FundWt).HasColumnName("FUND_WT");

                entity.Property(e => e.ProjId).HasColumnName("PROJ_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");
            });

            modelBuilder.Entity<Projissu>(entity =>
            {
                entity.HasKey(e => e.IssueId);

                entity.ToTable("PROJISSU");

                entity.HasIndex(e => e.ProjId, "ndx_projissu_proj_id");

                entity.Property(e => e.IssueId)
                    .ValueGeneratedNever()
                    .HasColumnName("ISSUE_ID");

                entity.Property(e => e.AddByName)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("ADD_BY_NAME");

                entity.Property(e => e.AddDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.BaseProjId).HasColumnName("BASE_PROJ_ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.HiParmValue).HasColumnName("HI_PARM_VALUE");

                entity.Property(e => e.IssueName)
                    .HasColumnType("TEXT(100)")
                    .HasColumnName("ISSUE_NAME");

                entity.Property(e => e.IssueNotes).HasColumnName("ISSUE_NOTES");

                entity.Property(e => e.IssueValue).HasColumnName("ISSUE_VALUE");

                entity.Property(e => e.LoParmValue).HasColumnName("LO_PARM_VALUE");

                entity.Property(e => e.ObsId).HasColumnName("OBS_ID");

                entity.Property(e => e.PriorityType)
                    .HasColumnType("TEXT(12)")
                    .HasColumnName("PRIORITY_TYPE");

                entity.Property(e => e.ProjId).HasColumnName("PROJ_ID");

                entity.Property(e => e.ResolvDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("RESOLV_DATE");

                entity.Property(e => e.RsrcId).HasColumnName("RSRC_ID");

                entity.Property(e => e.StatusCode)
                    .HasColumnType("TEXT(12)")
                    .HasColumnName("STATUS_CODE");

                entity.Property(e => e.TaskId).HasColumnName("TASK_ID");

                entity.Property(e => e.ThreshId).HasColumnName("THRESH_ID");

                entity.Property(e => e.ThreshParmId).HasColumnName("THRESH_PARM_ID");

                entity.Property(e => e.TrackViewId).HasColumnName("TRACK_VIEW_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.WbsId).HasColumnName("WBS_ID");

                entity.Property(e => e.WorkspaceId).HasColumnName("WORKSPACE_ID");
            });

            modelBuilder.Entity<Projpcat>(entity =>
            {
                entity.HasKey(e => new { e.ProjId, e.ProjCatgTypeId });

                entity.ToTable("PROJPCAT");

                entity.HasIndex(e => e.ProjCatgId, "ndx_projpcat_proj_catg_id");

                entity.Property(e => e.ProjId).HasColumnName("PROJ_ID");

                entity.Property(e => e.ProjCatgTypeId).HasColumnName("PROJ_CATG_TYPE_ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.ProjCatgId).HasColumnName("PROJ_CATG_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");
            });

            modelBuilder.Entity<Projprop>(entity =>
            {
                entity.HasKey(e => new { e.ProjId, e.PropName });

                entity.ToTable("PROJPROP");

                entity.Property(e => e.ProjId).HasColumnName("PROJ_ID");

                entity.Property(e => e.PropName)
                    .HasColumnType("TEXT(32)")
                    .HasColumnName("PROP_NAME");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.PropValue).HasColumnName("PROP_VALUE");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");
            });

            modelBuilder.Entity<Projrisk>(entity =>
            {
                entity.HasKey(e => e.RiskId);

                entity.ToTable("PROJRISK");

                entity.HasIndex(e => e.ProjId, "ndx_projrisk_proj_id");

                entity.Property(e => e.RiskId)
                    .ValueGeneratedNever()
                    .HasColumnName("RISK_ID");

                entity.Property(e => e.AddDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.IdentifiedById).HasColumnName("IDENTIFIED_BY_ID");

                entity.Property(e => e.Notes)
                    .HasColumnType("TEXT(4000)")
                    .HasColumnName("NOTES");

                entity.Property(e => e.PostRspCostPrblty)
                    .HasColumnType("TEXT(2)")
                    .HasColumnName("POST_RSP_COST_PRBLTY");

                entity.Property(e => e.PostRspPrblty)
                    .HasColumnType("TEXT(2)")
                    .HasColumnName("POST_RSP_PRBLTY");

                entity.Property(e => e.PostRspSchdPrblty)
                    .HasColumnType("TEXT(2)")
                    .HasColumnName("POST_RSP_SCHD_PRBLTY");

                entity.Property(e => e.PreRspCostPrblty)
                    .HasColumnType("TEXT(2)")
                    .HasColumnName("PRE_RSP_COST_PRBLTY");

                entity.Property(e => e.PreRspPrblty)
                    .HasColumnType("TEXT(2)")
                    .HasColumnName("PRE_RSP_PRBLTY");

                entity.Property(e => e.PreRspSchdPrblty)
                    .HasColumnType("TEXT(2)")
                    .HasColumnName("PRE_RSP_SCHD_PRBLTY");

                entity.Property(e => e.ProjId).HasColumnName("PROJ_ID");

                entity.Property(e => e.ResponseText)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("RESPONSE_TEXT");

                entity.Property(e => e.ResponseType)
                    .HasColumnType("TEXT(12)")
                    .HasColumnName("RESPONSE_TYPE");

                entity.Property(e => e.RiskCause)
                    .HasColumnType("TEXT(4000)")
                    .HasColumnName("RISK_CAUSE");

                entity.Property(e => e.RiskCode)
                    .HasColumnType("TEXT(40)")
                    .HasColumnName("RISK_CODE");

                entity.Property(e => e.RiskDesc)
                    .HasColumnType("TEXT(4000)")
                    .HasColumnName("RISK_DESC");

                entity.Property(e => e.RiskDescr).HasColumnName("RISK_DESCR");

                entity.Property(e => e.RiskEffect)
                    .HasColumnType("TEXT(4000)")
                    .HasColumnName("RISK_EFFECT");

                entity.Property(e => e.RiskName)
                    .HasColumnType("TEXT(200)")
                    .HasColumnName("RISK_NAME");

                entity.Property(e => e.RiskToType)
                    .HasColumnType("TEXT(12)")
                    .HasColumnName("RISK_TO_TYPE");

                entity.Property(e => e.RiskTypeId).HasColumnName("RISK_TYPE_ID");

                entity.Property(e => e.RsrcId).HasColumnName("RSRC_ID");

                entity.Property(e => e.StatusCode)
                    .HasColumnType("TEXT(12)")
                    .HasColumnName("STATUS_CODE");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");
            });

            modelBuilder.Entity<Projshar>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PROJSHAR");

                entity.Property(e => e.AccessLevel).HasColumnName("ACCESS_LEVEL");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.LoadStatus)
                    .HasColumnType("TEXT(1)")
                    .HasColumnName("LOAD_STATUS");

                entity.Property(e => e.ProjId).HasColumnName("PROJ_ID");

                entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");
            });

            modelBuilder.Entity<Projthr>(entity =>
            {
                entity.HasKey(e => e.ThreshId);

                entity.ToTable("PROJTHRS");

                entity.HasIndex(e => e.ProjId, "ndx_projthrs_proj_id");

                entity.Property(e => e.ThreshId)
                    .ValueGeneratedNever()
                    .HasColumnName("THRESH_ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.HiParmValue).HasColumnName("HI_PARM_VALUE");

                entity.Property(e => e.LoParmValue).HasColumnName("LO_PARM_VALUE");

                entity.Property(e => e.ObsId).HasColumnName("OBS_ID");

                entity.Property(e => e.PriorityType)
                    .HasColumnType("TEXT(12)")
                    .HasColumnName("PRIORITY_TYPE");

                entity.Property(e => e.ProjId).HasColumnName("PROJ_ID");

                entity.Property(e => e.StatusCode)
                    .HasColumnType("TEXT(12)")
                    .HasColumnName("STATUS_CODE");

                entity.Property(e => e.ThreshParmId).HasColumnName("THRESH_PARM_ID");

                entity.Property(e => e.ThreshType)
                    .HasColumnType("TEXT(12)")
                    .HasColumnName("THRESH_TYPE");

                entity.Property(e => e.TrackViewId).HasColumnName("TRACK_VIEW_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.WbsId).HasColumnName("WBS_ID");

                entity.Property(e => e.WindowEnd)
                    .HasColumnType("TEXT(50)")
                    .HasColumnName("WINDOW_END");

                entity.Property(e => e.WindowStart)
                    .HasColumnType("TEXT(50)")
                    .HasColumnName("WINDOW_START");
            });

            modelBuilder.Entity<Projwb>(entity =>
            {
                entity.HasKey(e => e.WbsId);

                entity.ToTable("PROJWBS");

                entity.HasIndex(e => e.ProjId, "ndx_projwbs_proj_id");

                entity.Property(e => e.WbsId)
                    .ValueGeneratedNever()
                    .HasColumnName("WBS_ID");

                entity.Property(e => e.AnnDscntRatePct).HasColumnName("ANN_DSCNT_RATE_PCT");

                entity.Property(e => e.AnticipEndDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("ANTICIP_END_DATE");

                entity.Property(e => e.AnticipStartDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("ANTICIP_START_DATE");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.DscntPeriodType)
                    .HasColumnType("TEXT(20)")
                    .HasColumnName("DSCNT_PERIOD_TYPE");

                entity.Property(e => e.EstWt).HasColumnName("EST_WT");

                entity.Property(e => e.EvComputeType)
                    .HasColumnType("TEXT(20)")
                    .HasColumnName("EV_COMPUTE_TYPE");

                entity.Property(e => e.EvEtcComputeType)
                    .HasColumnType("TEXT(20)")
                    .HasColumnName("EV_ETC_COMPUTE_TYPE");

                entity.Property(e => e.EvEtcUserValue).HasColumnName("EV_ETC_USER_VALUE");

                entity.Property(e => e.EvUserPct).HasColumnName("EV_USER_PCT");

                entity.Property(e => e.Guid)
                    .HasColumnType("TEXT(22)")
                    .HasColumnName("GUID");

                entity.Property(e => e.IndepRemainTotalCost).HasColumnName("INDEP_REMAIN_TOTAL_COST");

                entity.Property(e => e.IndepRemainWorkQty).HasColumnName("INDEP_REMAIN_WORK_QTY");

                entity.Property(e => e.ObsId).HasColumnName("OBS_ID");

                entity.Property(e => e.OrigCost).HasColumnName("ORIG_COST");

                entity.Property(e => e.ParentWbsId).HasColumnName("PARENT_WBS_ID");

                entity.Property(e => e.PhaseId).HasColumnName("PHASE_ID");

                entity.Property(e => e.ProjId).HasColumnName("PROJ_ID");

                entity.Property(e => e.ProjNodeFlag)
                    .HasColumnType("TEXT(1)")
                    .HasColumnName("PROJ_NODE_FLAG");

                entity.Property(e => e.SeqNum).HasColumnName("SEQ_NUM");

                entity.Property(e => e.StatusCode)
                    .HasColumnType("TEXT(20)")
                    .HasColumnName("STATUS_CODE");

                entity.Property(e => e.SumDataFlag)
                    .HasColumnType("TEXT(1)")
                    .HasColumnName("SUM_DATA_FLAG");

                entity.Property(e => e.TmplGuid)
                    .HasColumnType("TEXT(22)")
                    .HasColumnName("TMPL_GUID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.WbsName)
                    .HasColumnType("TEXT(100)")
                    .HasColumnName("WBS_NAME");

                entity.Property(e => e.WbsShortName)
                    .HasColumnType("TEXT(40)")
                    .HasColumnName("WBS_SHORT_NAME");
            });

            modelBuilder.Entity<Prpfolio>(entity =>
            {
                entity.HasKey(e => new { e.PfolioId, e.WbsId });

                entity.ToTable("PRPFOLIO");

                entity.Property(e => e.PfolioId).HasColumnName("PFOLIO_ID");

                entity.Property(e => e.WbsId).HasColumnName("WBS_ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");
            });

            modelBuilder.Entity<Rcattype>(entity =>
            {
                entity.HasKey(e => e.RsrcCatgTypeId);

                entity.ToTable("RCATTYPE");

                entity.Property(e => e.RsrcCatgTypeId)
                    .ValueGeneratedNever()
                    .HasColumnName("RSRC_CATG_TYPE_ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.RsrcCatgShortLen).HasColumnName("RSRC_CATG_SHORT_LEN");

                entity.Property(e => e.RsrcCatgType)
                    .HasColumnType("TEXT(40)")
                    .HasColumnName("RSRC_CATG_TYPE");

                entity.Property(e => e.SeqNum).HasColumnName("SEQ_NUM");

                entity.Property(e => e.SuperFlag)
                    .HasColumnType("TEXT(1)")
                    .HasColumnName("SUPER_FLAG");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");
            });

            modelBuilder.Entity<Rcatval>(entity =>
            {
                entity.HasKey(e => e.RsrcCatgId);

                entity.ToTable("RCATVAL");

                entity.Property(e => e.RsrcCatgId)
                    .ValueGeneratedNever()
                    .HasColumnName("RSRC_CATG_ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.ParentRsrcCatgId).HasColumnName("PARENT_RSRC_CATG_ID");

                entity.Property(e => e.RsrcCatgName)
                    .HasColumnType("TEXT(100)")
                    .HasColumnName("RSRC_CATG_NAME");

                entity.Property(e => e.RsrcCatgShortName)
                    .HasColumnType("TEXT(32)")
                    .HasColumnName("RSRC_CATG_SHORT_NAME");

                entity.Property(e => e.RsrcCatgTypeId).HasColumnName("RSRC_CATG_TYPE_ID");

                entity.Property(e => e.SeqNum).HasColumnName("SEQ_NUM");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");
            });

            modelBuilder.Entity<Refrdel>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("REFRDEL");

                entity.HasIndex(e => new { e.Pk1, e.Pk2, e.TableName }, "ndx_refrdel_pk1_pk2_tablename");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.Pk1)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("PK1");

                entity.Property(e => e.Pk2)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("PK2");

                entity.Property(e => e.Pk3)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("PK3");

                entity.Property(e => e.Pk4)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("PK4");

                entity.Property(e => e.ProjId).HasColumnName("PROJ_ID");

                entity.Property(e => e.TableName)
                    .HasColumnType("TEXT(30)")
                    .HasColumnName("TABLE_NAME");
            });

            modelBuilder.Entity<Rfolio>(entity =>
            {
                entity.ToTable("RFOLIO");

                entity.Property(e => e.RfolioId)
                    .ValueGeneratedNever()
                    .HasColumnName("RFOLIO_ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.RfolioDescr)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("RFOLIO_DESCR");

                entity.Property(e => e.RfolioName)
                    .HasColumnType("TEXT(40)")
                    .HasColumnName("RFOLIO_NAME");

                entity.Property(e => e.RfolioType)
                    .HasColumnType("TEXT(20)")
                    .HasColumnName("RFOLIO_TYPE");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.UserId).HasColumnName("USER_ID");
            });

            modelBuilder.Entity<Risktype>(entity =>
            {
                entity.ToTable("RISKTYPE");

                entity.Property(e => e.RiskTypeId)
                    .ValueGeneratedNever()
                    .HasColumnName("RISK_TYPE_ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.ParentRiskTypeId).HasColumnName("PARENT_RISK_TYPE_ID");

                entity.Property(e => e.RiskType1)
                    .HasColumnType("TEXT(40)")
                    .HasColumnName("RISK_TYPE");

                entity.Property(e => e.SeqNum).HasColumnName("SEQ_NUM");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("ROLES");

                entity.Property(e => e.RoleId)
                    .ValueGeneratedNever()
                    .HasColumnName("ROLE_ID");

                entity.Property(e => e.CostQtyType)
                    .HasColumnType("TEXT(24)")
                    .HasColumnName("COST_QTY_TYPE");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.DefCostQtyLinkFlag)
                    .HasColumnType("TEXT(1)")
                    .HasColumnName("DEF_COST_QTY_LINK_FLAG");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.ParentRoleId).HasColumnName("PARENT_ROLE_ID");

                entity.Property(e => e.PobsId).HasColumnName("POBS_ID");

                entity.Property(e => e.RoleDescr).HasColumnName("ROLE_DESCR");

                entity.Property(e => e.RoleName)
                    .HasColumnType("TEXT(100)")
                    .HasColumnName("ROLE_NAME");

                entity.Property(e => e.RoleShortName)
                    .HasColumnType("TEXT(40)")
                    .HasColumnName("ROLE_SHORT_NAME");

                entity.Property(e => e.SeqNum).HasColumnName("SEQ_NUM");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");
            });

            modelBuilder.Entity<Rolecattype>(entity =>
            {
                entity.HasKey(e => e.RoleCatgTypeId);

                entity.ToTable("ROLECATTYPE");

                entity.Property(e => e.RoleCatgTypeId)
                    .ValueGeneratedNever()
                    .HasColumnName("ROLE_CATG_TYPE_ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.RoleCatgShortLen).HasColumnName("ROLE_CATG_SHORT_LEN");

                entity.Property(e => e.RoleCatgType)
                    .HasColumnType("TEXT(40)")
                    .HasColumnName("ROLE_CATG_TYPE");

                entity.Property(e => e.SeqNum).HasColumnName("SEQ_NUM");

                entity.Property(e => e.SuperFlag)
                    .HasColumnType("TEXT(1)")
                    .HasColumnName("SUPER_FLAG")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");
            });

            modelBuilder.Entity<Rolecatval>(entity =>
            {
                entity.HasKey(e => e.RoleCatgId);

                entity.ToTable("ROLECATVAL");

                entity.Property(e => e.RoleCatgId)
                    .ValueGeneratedNever()
                    .HasColumnName("ROLE_CATG_ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.ParentRoleCatgId).HasColumnName("PARENT_ROLE_CATG_ID");

                entity.Property(e => e.RoleCatgName)
                    .HasColumnType("TEXT(100)")
                    .HasColumnName("ROLE_CATG_NAME");

                entity.Property(e => e.RoleCatgShortName)
                    .HasColumnType("TEXT(60)")
                    .HasColumnName("ROLE_CATG_SHORT_NAME");

                entity.Property(e => e.RoleCatgTypeId).HasColumnName("ROLE_CATG_TYPE_ID");

                entity.Property(e => e.SeqNum).HasColumnName("SEQ_NUM");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");
            });

            modelBuilder.Entity<Rolelimit>(entity =>
            {
                entity.ToTable("ROLELIMIT");

                entity.Property(e => e.RolelimitId)
                    .ValueGeneratedNever()
                    .HasColumnName("ROLELIMIT_ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.MaxQtyPerHr).HasColumnName("MAX_QTY_PER_HR");

                entity.Property(e => e.RoleId).HasColumnName("ROLE_ID");

                entity.Property(e => e.StartDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("START_DATE");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");
            });

            modelBuilder.Entity<Rolerate>(entity =>
            {
                entity.ToTable("ROLERATE");

                entity.Property(e => e.RoleRateId)
                    .ValueGeneratedNever()
                    .HasColumnName("ROLE_RATE_ID");

                entity.Property(e => e.CostPerQty).HasColumnName("COST_PER_QTY");

                entity.Property(e => e.CostPerQty2).HasColumnName("COST_PER_QTY2");

                entity.Property(e => e.CostPerQty3).HasColumnName("COST_PER_QTY3");

                entity.Property(e => e.CostPerQty4).HasColumnName("COST_PER_QTY4");

                entity.Property(e => e.CostPerQty5).HasColumnName("COST_PER_QTY5");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.MaxQtyPerHr)
                    .HasColumnName("MAX_QTY_PER_HR")
                    .HasDefaultValueSql("0.0");

                entity.Property(e => e.RoleId).HasColumnName("ROLE_ID");

                entity.Property(e => e.StartDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("START_DATE")
                    .HasDefaultValueSql("'1976-01-01 12:00:00'");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");
            });

            modelBuilder.Entity<Rolercat>(entity =>
            {
                entity.HasKey(e => new { e.RoleId, e.RoleCatgTypeId });

                entity.ToTable("ROLERCAT");

                entity.Property(e => e.RoleId).HasColumnName("ROLE_ID");

                entity.Property(e => e.RoleCatgTypeId).HasColumnName("ROLE_CATG_TYPE_ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.RoleCatgId).HasColumnName("ROLE_CATG_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");
            });

            modelBuilder.Entity<Rpt>(entity =>
            {
                entity.ToTable("RPT");

                entity.HasIndex(e => e.ProjId, "ndx_rpt_proj_id");

                entity.Property(e => e.RptId)
                    .ValueGeneratedNever()
                    .HasColumnName("RPT_ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.GlobalFlag)
                    .HasColumnType("TEXT(1)")
                    .HasColumnName("GLOBAL_FLAG");

                entity.Property(e => e.LastRunDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("LAST_RUN_DATE");

                entity.Property(e => e.ProjId).HasColumnName("PROJ_ID");

                entity.Property(e => e.RptArea)
                    .HasColumnType("TEXT(32)")
                    .HasColumnName("RPT_AREA");

                entity.Property(e => e.RptData).HasColumnName("RPT_DATA");

                entity.Property(e => e.RptGroupId).HasColumnName("RPT_GROUP_ID");

                entity.Property(e => e.RptName)
                    .HasColumnType("TEXT(80)")
                    .HasColumnName("RPT_NAME");

                entity.Property(e => e.RptState)
                    .HasColumnType("TEXT(10)")
                    .HasColumnName("RPT_STATE");

                entity.Property(e => e.RptType)
                    .HasColumnType("TEXT(12)")
                    .HasColumnName("RPT_TYPE");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.UserId).HasColumnName("USER_ID");
            });

            modelBuilder.Entity<Rptbatch>(entity =>
            {
                entity.ToTable("RPTBATCH");

                entity.HasIndex(e => e.ProjId, "ndx_rptbatch_proj_id");

                entity.Property(e => e.RptBatchId)
                    .ValueGeneratedNever()
                    .HasColumnName("RPT_BATCH_ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.ProjId).HasColumnName("PROJ_ID");

                entity.Property(e => e.RptBatchName)
                    .HasColumnType("TEXT(80)")
                    .HasColumnName("RPT_BATCH_NAME");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");
            });

            modelBuilder.Entity<Rptgroup>(entity =>
            {
                entity.ToTable("RPTGROUP");

                entity.Property(e => e.RptGroupId)
                    .ValueGeneratedNever()
                    .HasColumnName("RPT_GROUP_ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.ParentGroupId).HasColumnName("PARENT_GROUP_ID");

                entity.Property(e => e.RptGroupName)
                    .HasColumnType("TEXT(80)")
                    .HasColumnName("RPT_GROUP_NAME");

                entity.Property(e => e.RptGroupSeqNum).HasColumnName("RPT_GROUP_SEQ_NUM");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");
            });

            modelBuilder.Entity<Rptlist>(entity =>
            {
                entity.HasKey(e => new { e.RptBatchId, e.RptId });

                entity.ToTable("RPTLIST");

                entity.Property(e => e.RptBatchId).HasColumnName("RPT_BATCH_ID");

                entity.Property(e => e.RptId).HasColumnName("RPT_ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.SeqNum).HasColumnName("SEQ_NUM");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");
            });

            modelBuilder.Entity<Rsrc>(entity =>
            {
                entity.ToTable("RSRC");

                entity.Property(e => e.RsrcId)
                    .ValueGeneratedNever()
                    .HasColumnName("RSRC_ID");

                entity.Property(e => e.ActiveFlag)
                    .HasColumnType("TEXT(1)")
                    .HasColumnName("ACTIVE_FLAG");

                entity.Property(e => e.AutoComputeActFlag)
                    .HasColumnType("TEXT(1)")
                    .HasColumnName("AUTO_COMPUTE_ACT_FLAG");

                entity.Property(e => e.ClndrId).HasColumnName("CLNDR_ID");

                entity.Property(e => e.CostQtyType)
                    .HasColumnType("TEXT(24)")
                    .HasColumnName("COST_QTY_TYPE");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.CurrId).HasColumnName("CURR_ID");

                entity.Property(e => e.DefCostQtyLinkFlag)
                    .HasColumnType("TEXT(1)")
                    .HasColumnName("DEF_COST_QTY_LINK_FLAG");

                entity.Property(e => e.DefQtyPerHr).HasColumnName("DEF_QTY_PER_HR");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.EmailAddr)
                    .HasColumnType("TEXT(120)")
                    .HasColumnName("EMAIL_ADDR");

                entity.Property(e => e.EmployeeCode)
                    .HasColumnType("TEXT(40)")
                    .HasColumnName("EMPLOYEE_CODE");

                entity.Property(e => e.Guid)
                    .HasColumnType("TEXT(22)")
                    .HasColumnName("GUID");

                entity.Property(e => e.LocationId).HasColumnName("LOCATION_ID");

                entity.Property(e => e.OfficePhone)
                    .HasColumnType("TEXT(32)")
                    .HasColumnName("OFFICE_PHONE");

                entity.Property(e => e.OtFactor).HasColumnName("OT_FACTOR");

                entity.Property(e => e.OtFlag)
                    .HasColumnType("TEXT(1)")
                    .HasColumnName("OT_FLAG");

                entity.Property(e => e.OtherPhone)
                    .HasColumnType("TEXT(32)")
                    .HasColumnName("OTHER_PHONE");

                entity.Property(e => e.ParentRsrcId).HasColumnName("PARENT_RSRC_ID");

                entity.Property(e => e.PobsId).HasColumnName("POBS_ID");

                entity.Property(e => e.RoleId).HasColumnName("ROLE_ID");

                entity.Property(e => e.RsrcName)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("RSRC_NAME");

                entity.Property(e => e.RsrcNotes).HasColumnName("RSRC_NOTES");

                entity.Property(e => e.RsrcSeqNum).HasColumnName("RSRC_SEQ_NUM");

                entity.Property(e => e.RsrcShortName)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("RSRC_SHORT_NAME");

                entity.Property(e => e.RsrcTitleName)
                    .HasColumnType("TEXT(100)")
                    .HasColumnName("RSRC_TITLE_NAME");

                entity.Property(e => e.RsrcType)
                    .HasColumnType("TEXT(10)")
                    .HasColumnName("RSRC_TYPE");

                entity.Property(e => e.ShiftId).HasColumnName("SHIFT_ID");

                entity.Property(e => e.TimesheetFlag)
                    .HasColumnType("TEXT(1)")
                    .HasColumnName("TIMESHEET_FLAG")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.UnitId).HasColumnName("UNIT_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.UserId).HasColumnName("USER_ID");
            });

            modelBuilder.Entity<Rsrccurv>(entity =>
            {
                entity.HasKey(e => e.CurvId);

                entity.ToTable("RSRCCURV");

                entity.Property(e => e.CurvId)
                    .ValueGeneratedNever()
                    .HasColumnName("CURV_ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.CurvData).HasColumnName("CURV_DATA");

                entity.Property(e => e.CurvName)
                    .HasColumnType("TEXT(60)")
                    .HasColumnName("CURV_NAME");

                entity.Property(e => e.DefaultFlag)
                    .HasColumnType("TEXT(1)")
                    .HasColumnName("DEFAULT_FLAG");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");
            });

            modelBuilder.Entity<Rsrcrate>(entity =>
            {
                entity.ToTable("RSRCRATE");

                entity.Property(e => e.RsrcRateId)
                    .ValueGeneratedNever()
                    .HasColumnName("RSRC_RATE_ID");

                entity.Property(e => e.CostPerQty).HasColumnName("COST_PER_QTY");

                entity.Property(e => e.CostPerQty2).HasColumnName("COST_PER_QTY2");

                entity.Property(e => e.CostPerQty3).HasColumnName("COST_PER_QTY3");

                entity.Property(e => e.CostPerQty4).HasColumnName("COST_PER_QTY4");

                entity.Property(e => e.CostPerQty5).HasColumnName("COST_PER_QTY5");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.MaxQtyPerHr).HasColumnName("MAX_QTY_PER_HR");

                entity.Property(e => e.RsrcId).HasColumnName("RSRC_ID");

                entity.Property(e => e.ShiftPeriodId).HasColumnName("SHIFT_PERIOD_ID");

                entity.Property(e => e.StartDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("START_DATE");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");
            });

            modelBuilder.Entity<Rsrcrcat>(entity =>
            {
                entity.HasKey(e => new { e.RsrcId, e.RsrcCatgTypeId });

                entity.ToTable("RSRCRCAT");

                entity.Property(e => e.RsrcId).HasColumnName("RSRC_ID");

                entity.Property(e => e.RsrcCatgTypeId).HasColumnName("RSRC_CATG_TYPE_ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.RsrcCatgId).HasColumnName("RSRC_CATG_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");
            });

            modelBuilder.Entity<Rsrcrole>(entity =>
            {
                entity.HasKey(e => new { e.RsrcId, e.RoleId });

                entity.ToTable("RSRCROLE");

                entity.Property(e => e.RsrcId).HasColumnName("RSRC_ID");

                entity.Property(e => e.RoleId).HasColumnName("ROLE_ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.SkillLevel).HasColumnName("SKILL_LEVEL");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");
            });

            modelBuilder.Entity<Rsrcsec>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RsrcId });

                entity.ToTable("RSRCSEC");

                entity.Property(e => e.UserId).HasColumnName("USER_ID");

                entity.Property(e => e.RsrcId).HasColumnName("RSRC_ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");
            });

            modelBuilder.Entity<Rsrfolio>(entity =>
            {
                entity.HasKey(e => new { e.RfolioId, e.RsrcId });

                entity.ToTable("RSRFOLIO");

                entity.Property(e => e.RfolioId).HasColumnName("RFOLIO_ID");

                entity.Property(e => e.RsrcId).HasColumnName("RSRC_ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");
            });

            modelBuilder.Entity<Setting>(entity =>
            {
                entity.HasKey(e => new { e.Namespace, e.SettingName });

                entity.ToTable("SETTINGS");

                entity.Property(e => e.Namespace)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("NAMESPACE");

                entity.Property(e => e.SettingName)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("SETTING_NAME");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.SettingValue)
                    .HasColumnType("TEXT(4000)")
                    .HasColumnName("SETTING_VALUE");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.UserId).HasColumnName("USER_ID");
            });

            modelBuilder.Entity<Shift>(entity =>
            {
                entity.ToTable("SHIFT");

                entity.Property(e => e.ShiftId)
                    .ValueGeneratedNever()
                    .HasColumnName("SHIFT_ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.ShiftName)
                    .HasColumnType("TEXT(60)")
                    .HasColumnName("SHIFT_NAME");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");
            });

            modelBuilder.Entity<Shiftper>(entity =>
            {
                entity.HasKey(e => e.ShiftPeriodId);

                entity.ToTable("SHIFTPER");

                entity.Property(e => e.ShiftPeriodId)
                    .ValueGeneratedNever()
                    .HasColumnName("SHIFT_PERIOD_ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.ShiftId).HasColumnName("SHIFT_ID");

                entity.Property(e => e.ShiftStartHrNum).HasColumnName("SHIFT_START_HR_NUM");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");
            });

            modelBuilder.Entity<Sumtask>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SUMTASK");

                entity.Property(e => e.ActDrtnHrCnt).HasColumnName("ACT_DRTN_HR_CNT");

                entity.Property(e => e.ActEndDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("ACT_END_DATE");

                entity.Property(e => e.ActEquipCost).HasColumnName("ACT_EQUIP_COST");

                entity.Property(e => e.ActEquipQty).HasColumnName("ACT_EQUIP_QTY");

                entity.Property(e => e.ActExpenseCost).HasColumnName("ACT_EXPENSE_COST");

                entity.Property(e => e.ActMatCost).HasColumnName("ACT_MAT_COST");

                entity.Property(e => e.ActStartDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("ACT_START_DATE");

                entity.Property(e => e.ActThisPerEquipCost).HasColumnName("ACT_THIS_PER_EQUIP_COST");

                entity.Property(e => e.ActThisPerEquipQty).HasColumnName("ACT_THIS_PER_EQUIP_QTY");

                entity.Property(e => e.ActThisPerMatCost).HasColumnName("ACT_THIS_PER_MAT_COST");

                entity.Property(e => e.ActThisPerWorkCost).HasColumnName("ACT_THIS_PER_WORK_COST");

                entity.Property(e => e.ActThisPerWorkQty).HasColumnName("ACT_THIS_PER_WORK_QTY");

                entity.Property(e => e.ActWorkCost).HasColumnName("ACT_WORK_COST");

                entity.Property(e => e.ActWorkQty).HasColumnName("ACT_WORK_QTY");

                entity.Property(e => e.ActiveCnt).HasColumnName("ACTIVE_CNT");

                entity.Property(e => e.BaseActiveCnt).HasColumnName("BASE_ACTIVE_CNT");

                entity.Property(e => e.BaseCompleteCnt).HasColumnName("BASE_COMPLETE_CNT");

                entity.Property(e => e.BaseDrtnHrCnt).HasColumnName("BASE_DRTN_HR_CNT");

                entity.Property(e => e.BaseEndDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("BASE_END_DATE");

                entity.Property(e => e.BaseEquipCost).HasColumnName("BASE_EQUIP_COST");

                entity.Property(e => e.BaseEquipQty).HasColumnName("BASE_EQUIP_QTY");

                entity.Property(e => e.BaseExpenseCost).HasColumnName("BASE_EXPENSE_COST");

                entity.Property(e => e.BaseMatCost).HasColumnName("BASE_MAT_COST");

                entity.Property(e => e.BaseNotstartedCnt).HasColumnName("BASE_NOTSTARTED_CNT");

                entity.Property(e => e.BaseStartDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("BASE_START_DATE");

                entity.Property(e => e.BaseWorkCost).HasColumnName("BASE_WORK_COST");

                entity.Property(e => e.BaseWorkQty).HasColumnName("BASE_WORK_QTY");

                entity.Property(e => e.Bcwp).HasColumnName("BCWP");

                entity.Property(e => e.Bcws).HasColumnName("BCWS");

                entity.Property(e => e.CompleteCnt).HasColumnName("COMPLETE_CNT");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.EacWorkQty).HasColumnName("EAC_WORK_QTY");

                entity.Property(e => e.Etc).HasColumnName("ETC");

                entity.Property(e => e.EtcWorkQty).HasColumnName("ETC_WORK_QTY");

                entity.Property(e => e.NotstartedCnt).HasColumnName("NOTSTARTED_CNT");

                entity.Property(e => e.PerfmWorkQty).HasColumnName("PERFM_WORK_QTY");

                entity.Property(e => e.ProjId).HasColumnName("PROJ_ID");

                entity.Property(e => e.ReendDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("REEND_DATE");

                entity.Property(e => e.RemainDrtnHrCnt).HasColumnName("REMAIN_DRTN_HR_CNT");

                entity.Property(e => e.RemainEquipCost).HasColumnName("REMAIN_EQUIP_COST");

                entity.Property(e => e.RemainEquipQty).HasColumnName("REMAIN_EQUIP_QTY");

                entity.Property(e => e.RemainExpenseCost).HasColumnName("REMAIN_EXPENSE_COST");

                entity.Property(e => e.RemainMatCost).HasColumnName("REMAIN_MAT_COST");

                entity.Property(e => e.RemainWorkCost).HasColumnName("REMAIN_WORK_COST");

                entity.Property(e => e.RemainWorkQty).HasColumnName("REMAIN_WORK_QTY");

                entity.Property(e => e.RestartDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("RESTART_DATE");

                entity.Property(e => e.SchedWorkQty).HasColumnName("SCHED_WORK_QTY");

                entity.Property(e => e.TotalDrtnHrCnt).HasColumnName("TOTAL_DRTN_HR_CNT");

                entity.Property(e => e.TotalFloatHrCnt).HasColumnName("TOTAL_FLOAT_HR_CNT");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.WbsId).HasColumnName("WBS_ID");
            });

            modelBuilder.Entity<Sumtaskspread>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SUMTASKSPREAD");

                entity.Property(e => e.ActCost).HasColumnName("ACT_COST");

                entity.Property(e => e.ActEquipCost).HasColumnName("ACT_EQUIP_COST");

                entity.Property(e => e.ActEquipQty).HasColumnName("ACT_EQUIP_QTY");

                entity.Property(e => e.ActExpenseCost).HasColumnName("ACT_EXPENSE_COST");

                entity.Property(e => e.ActMatCost).HasColumnName("ACT_MAT_COST");

                entity.Property(e => e.ActWorkCost).HasColumnName("ACT_WORK_COST");

                entity.Property(e => e.ActWorkQty).HasColumnName("ACT_WORK_QTY");

                entity.Property(e => e.Acwp).HasColumnName("ACWP");

                entity.Property(e => e.BaseCost).HasColumnName("BASE_COST");

                entity.Property(e => e.BaseEquipCost).HasColumnName("BASE_EQUIP_COST");

                entity.Property(e => e.BaseEquipQty).HasColumnName("BASE_EQUIP_QTY");

                entity.Property(e => e.BaseExpenseCost).HasColumnName("BASE_EXPENSE_COST");

                entity.Property(e => e.BaseMatCost).HasColumnName("BASE_MAT_COST");

                entity.Property(e => e.BaseWorkCost).HasColumnName("BASE_WORK_COST");

                entity.Property(e => e.BaseWorkQty).HasColumnName("BASE_WORK_QTY");

                entity.Property(e => e.Bcwp).HasColumnName("BCWP");

                entity.Property(e => e.Bcws).HasColumnName("BCWS");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.Eac).HasColumnName("EAC");

                entity.Property(e => e.EacWork).HasColumnName("EAC_WORK");

                entity.Property(e => e.EacWorkQty).HasColumnName("EAC_WORK_QTY");

                entity.Property(e => e.EndDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("END_DATE");

                entity.Property(e => e.Etc).HasColumnName("ETC");

                entity.Property(e => e.EtcWorkQty).HasColumnName("ETC_WORK_QTY");

                entity.Property(e => e.FinPeriodActCost).HasColumnName("FIN_PERIOD_ACT_COST");

                entity.Property(e => e.FinPeriodActEquipCost).HasColumnName("FIN_PERIOD_ACT_EQUIP_COST");

                entity.Property(e => e.FinPeriodActEquipQty).HasColumnName("FIN_PERIOD_ACT_EQUIP_QTY");

                entity.Property(e => e.FinPeriodActExpenseCost).HasColumnName("FIN_PERIOD_ACT_EXPENSE_COST");

                entity.Property(e => e.FinPeriodActMatCost).HasColumnName("FIN_PERIOD_ACT_MAT_COST");

                entity.Property(e => e.FinPeriodActWorkCost).HasColumnName("FIN_PERIOD_ACT_WORK_COST");

                entity.Property(e => e.FinPeriodActWorkQty).HasColumnName("FIN_PERIOD_ACT_WORK_QTY");

                entity.Property(e => e.FinPeriodBcwp).HasColumnName("FIN_PERIOD_BCWP");

                entity.Property(e => e.FinPeriodBcws).HasColumnName("FIN_PERIOD_BCWS");

                entity.Property(e => e.FinPeriodEac).HasColumnName("FIN_PERIOD_EAC");

                entity.Property(e => e.FinPeriodEacWork).HasColumnName("FIN_PERIOD_EAC_WORK");

                entity.Property(e => e.FinPeriodEacWorkQty).HasColumnName("FIN_PERIOD_EAC_WORK_QTY");

                entity.Property(e => e.FinPeriodPerfmWorkQty).HasColumnName("FIN_PERIOD_PERFM_WORK_QTY");

                entity.Property(e => e.FinPeriodSchedWorkQty).HasColumnName("FIN_PERIOD_SCHED_WORK_QTY");

                entity.Property(e => e.FinPeriodTotalCost).HasColumnName("FIN_PERIOD_TOTAL_COST");

                entity.Property(e => e.FinPeriodTotalEquipCost).HasColumnName("FIN_PERIOD_TOTAL_EQUIP_COST");

                entity.Property(e => e.FinPeriodTotalEquipQty).HasColumnName("FIN_PERIOD_TOTAL_EQUIP_QTY");

                entity.Property(e => e.FinPeriodTotalExpenseCost).HasColumnName("FIN_PERIOD_TOTAL_EXPENSE_COST");

                entity.Property(e => e.FinPeriodTotalMatCost).HasColumnName("FIN_PERIOD_TOTAL_MAT_COST");

                entity.Property(e => e.FinPeriodTotalWorkCost).HasColumnName("FIN_PERIOD_TOTAL_WORK_COST");

                entity.Property(e => e.FinPeriodTotalWorkQty).HasColumnName("FIN_PERIOD_TOTAL_WORK_QTY");

                entity.Property(e => e.LateRemainCost).HasColumnName("LATE_REMAIN_COST");

                entity.Property(e => e.LateRemainEquipCost).HasColumnName("LATE_REMAIN_EQUIP_COST");

                entity.Property(e => e.LateRemainEquipQty).HasColumnName("LATE_REMAIN_EQUIP_QTY");

                entity.Property(e => e.LateRemainExpenseCost).HasColumnName("LATE_REMAIN_EXPENSE_COST");

                entity.Property(e => e.LateRemainMatCost).HasColumnName("LATE_REMAIN_MAT_COST");

                entity.Property(e => e.LateRemainWorkCost).HasColumnName("LATE_REMAIN_WORK_COST");

                entity.Property(e => e.LateRemainWorkQty).HasColumnName("LATE_REMAIN_WORK_QTY");

                entity.Property(e => e.PerfmWorkQty).HasColumnName("PERFM_WORK_QTY");

                entity.Property(e => e.ProjId).HasColumnName("PROJ_ID");

                entity.Property(e => e.RemainCost).HasColumnName("REMAIN_COST");

                entity.Property(e => e.RemainEquipCost).HasColumnName("REMAIN_EQUIP_COST");

                entity.Property(e => e.RemainEquipQty).HasColumnName("REMAIN_EQUIP_QTY");

                entity.Property(e => e.RemainExpenseCost).HasColumnName("REMAIN_EXPENSE_COST");

                entity.Property(e => e.RemainMatCost).HasColumnName("REMAIN_MAT_COST");

                entity.Property(e => e.RemainWorkCost).HasColumnName("REMAIN_WORK_COST");

                entity.Property(e => e.RemainWorkQty).HasColumnName("REMAIN_WORK_QTY");

                entity.Property(e => e.SchedWorkQty).HasColumnName("SCHED_WORK_QTY");

                entity.Property(e => e.SpreadType)
                    .HasColumnType("TEXT(20)")
                    .HasColumnName("SPREAD_TYPE");

                entity.Property(e => e.StartDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("START_DATE");

                entity.Property(e => e.TargetCost).HasColumnName("TARGET_COST");

                entity.Property(e => e.TargetEquipCost).HasColumnName("TARGET_EQUIP_COST");

                entity.Property(e => e.TargetEquipQty).HasColumnName("TARGET_EQUIP_QTY");

                entity.Property(e => e.TargetExpenseCost).HasColumnName("TARGET_EXPENSE_COST");

                entity.Property(e => e.TargetMatCost).HasColumnName("TARGET_MAT_COST");

                entity.Property(e => e.TargetWorkCost).HasColumnName("TARGET_WORK_COST");

                entity.Property(e => e.TargetWorkQty).HasColumnName("TARGET_WORK_QTY");

                entity.Property(e => e.TotalCost).HasColumnName("TOTAL_COST");

                entity.Property(e => e.TotalEquipCost).HasColumnName("TOTAL_EQUIP_COST");

                entity.Property(e => e.TotalEquipQty).HasColumnName("TOTAL_EQUIP_QTY");

                entity.Property(e => e.TotalExpenseCost).HasColumnName("TOTAL_EXPENSE_COST");

                entity.Property(e => e.TotalMatCost).HasColumnName("TOTAL_MAT_COST");

                entity.Property(e => e.TotalWorkCost).HasColumnName("TOTAL_WORK_COST");

                entity.Property(e => e.TotalWorkQty).HasColumnName("TOTAL_WORK_QTY");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.WbsId).HasColumnName("WBS_ID");
            });

            modelBuilder.Entity<Sumtrsrc>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SUMTRSRC");

                entity.Property(e => e.ActCost).HasColumnName("ACT_COST");

                entity.Property(e => e.ActOtCost).HasColumnName("ACT_OT_COST");

                entity.Property(e => e.ActOtQty).HasColumnName("ACT_OT_QTY");

                entity.Property(e => e.ActQty).HasColumnName("ACT_QTY");

                entity.Property(e => e.ActRegCost).HasColumnName("ACT_REG_COST");

                entity.Property(e => e.ActRegQty).HasColumnName("ACT_REG_QTY");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.EndDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("END_DATE");

                entity.Property(e => e.FinPeriodActCost).HasColumnName("FIN_PERIOD_ACT_COST");

                entity.Property(e => e.FinPeriodActQty).HasColumnName("FIN_PERIOD_ACT_QTY");

                entity.Property(e => e.FinPeriodTotalCost).HasColumnName("FIN_PERIOD_TOTAL_COST");

                entity.Property(e => e.FinPeriodTotalQty).HasColumnName("FIN_PERIOD_TOTAL_QTY");

                entity.Property(e => e.LateRemainCost).HasColumnName("LATE_REMAIN_COST");

                entity.Property(e => e.LateRemainQty).HasColumnName("LATE_REMAIN_QTY");

                entity.Property(e => e.ProjId).HasColumnName("PROJ_ID");

                entity.Property(e => e.RemainCost).HasColumnName("REMAIN_COST");

                entity.Property(e => e.RemainQty).HasColumnName("REMAIN_QTY");

                entity.Property(e => e.RoleId).HasColumnName("ROLE_ID");

                entity.Property(e => e.RsrcId).HasColumnName("RSRC_ID");

                entity.Property(e => e.SpreadType)
                    .HasColumnType("TEXT(20)")
                    .HasColumnName("SPREAD_TYPE");

                entity.Property(e => e.StaffedActCost).HasColumnName("STAFFED_ACT_COST");

                entity.Property(e => e.StaffedActOtCost).HasColumnName("STAFFED_ACT_OT_COST");

                entity.Property(e => e.StaffedActOtQty).HasColumnName("STAFFED_ACT_OT_QTY");

                entity.Property(e => e.StaffedActQty).HasColumnName("STAFFED_ACT_QTY");

                entity.Property(e => e.StaffedActRegCost).HasColumnName("STAFFED_ACT_REG_COST");

                entity.Property(e => e.StaffedActRegQty).HasColumnName("STAFFED_ACT_REG_QTY");

                entity.Property(e => e.StaffedLateRemainCost).HasColumnName("STAFFED_LATE_REMAIN_COST");

                entity.Property(e => e.StaffedLateRemainQty).HasColumnName("STAFFED_LATE_REMAIN_QTY");

                entity.Property(e => e.StaffedRemainCost).HasColumnName("STAFFED_REMAIN_COST");

                entity.Property(e => e.StaffedRemainQty).HasColumnName("STAFFED_REMAIN_QTY");

                entity.Property(e => e.StaffedTargetCost).HasColumnName("STAFFED_TARGET_COST");

                entity.Property(e => e.StaffedTargetQty).HasColumnName("STAFFED_TARGET_QTY");

                entity.Property(e => e.StaffedTotalCost).HasColumnName("STAFFED_TOTAL_COST");

                entity.Property(e => e.StaffedTotalQty).HasColumnName("STAFFED_TOTAL_QTY");

                entity.Property(e => e.StartDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("START_DATE");

                entity.Property(e => e.SumtrsrcId).HasColumnName("SUMTRSRC_ID");

                entity.Property(e => e.TargetCost).HasColumnName("TARGET_COST");

                entity.Property(e => e.TargetQty).HasColumnName("TARGET_QTY");

                entity.Property(e => e.TotalCost).HasColumnName("TOTAL_COST");

                entity.Property(e => e.TotalQty).HasColumnName("TOTAL_QTY");

                entity.Property(e => e.UnstaffedActCost).HasColumnName("UNSTAFFED_ACT_COST");

                entity.Property(e => e.UnstaffedActOtCost).HasColumnName("UNSTAFFED_ACT_OT_COST");

                entity.Property(e => e.UnstaffedActOtQty).HasColumnName("UNSTAFFED_ACT_OT_QTY");

                entity.Property(e => e.UnstaffedActQty).HasColumnName("UNSTAFFED_ACT_QTY");

                entity.Property(e => e.UnstaffedActRegCost).HasColumnName("UNSTAFFED_ACT_REG_COST");

                entity.Property(e => e.UnstaffedActRegQty).HasColumnName("UNSTAFFED_ACT_REG_QTY");

                entity.Property(e => e.UnstaffedLateRemainCost).HasColumnName("UNSTAFFED_LATE_REMAIN_COST");

                entity.Property(e => e.UnstaffedLateRemainQty).HasColumnName("UNSTAFFED_LATE_REMAIN_QTY");

                entity.Property(e => e.UnstaffedRemainCost).HasColumnName("UNSTAFFED_REMAIN_COST");

                entity.Property(e => e.UnstaffedRemainQty).HasColumnName("UNSTAFFED_REMAIN_QTY");

                entity.Property(e => e.UnstaffedTargetCost).HasColumnName("UNSTAFFED_TARGET_COST");

                entity.Property(e => e.UnstaffedTargetQty).HasColumnName("UNSTAFFED_TARGET_QTY");

                entity.Property(e => e.UnstaffedTotalCost).HasColumnName("UNSTAFFED_TOTAL_COST");

                entity.Property(e => e.UnstaffedTotalQty).HasColumnName("UNSTAFFED_TOTAL_QTY");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.WbsId).HasColumnName("WBS_ID");
            });

            modelBuilder.Entity<DatabaseManager.Model.Task>(entity =>
            {
                entity.ToTable("TASK");

                entity.Property(e => e.TaskId)
                    .ValueGeneratedNever()
                    .HasColumnName("TASK_ID");

                entity.Property(e => e.ActEndDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("ACT_END_DATE");

                entity.Property(e => e.ActEquipQty).HasColumnName("ACT_EQUIP_QTY");

                entity.Property(e => e.ActStartDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("ACT_START_DATE");

                entity.Property(e => e.ActThisPerEquipQty).HasColumnName("ACT_THIS_PER_EQUIP_QTY");

                entity.Property(e => e.ActThisPerWorkQty).HasColumnName("ACT_THIS_PER_WORK_QTY");

                entity.Property(e => e.ActWorkQty).HasColumnName("ACT_WORK_QTY");

                entity.Property(e => e.AutoComputeActFlag)
                    .HasColumnType("TEXT(1)")
                    .HasColumnName("AUTO_COMPUTE_ACT_FLAG");

                entity.Property(e => e.ClndrId).HasColumnName("CLNDR_ID");

                entity.Property(e => e.CompletePctType)
                    .HasColumnType("TEXT(10)")
                    .HasColumnName("COMPLETE_PCT_TYPE");

                entity.Property(e => e.ControlUpdatesFlag)
                    .HasColumnType("TEXT(1)")
                    .HasColumnName("CONTROL_UPDATES_FLAG")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.CstrDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CSTR_DATE");

                entity.Property(e => e.CstrDate2)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CSTR_DATE2");

                entity.Property(e => e.CstrType)
                    .HasColumnType("TEXT(12)")
                    .HasColumnName("CSTR_TYPE");

                entity.Property(e => e.CstrType2)
                    .HasColumnType("TEXT(12)")
                    .HasColumnName("CSTR_TYPE2");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.DrivingPathFlag)
                    .HasColumnType("TEXT(1)")
                    .HasColumnName("DRIVING_PATH_FLAG");

                entity.Property(e => e.DurationType)
                    .HasColumnType("TEXT(12)")
                    .HasColumnName("DURATION_TYPE");

                entity.Property(e => e.EarlyEndDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("EARLY_END_DATE");

                entity.Property(e => e.EarlyStartDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("EARLY_START_DATE");

                entity.Property(e => e.EstWt).HasColumnName("EST_WT");

                entity.Property(e => e.ExpectEndDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("EXPECT_END_DATE");

                entity.Property(e => e.ExternalEarlyStartDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("EXTERNAL_EARLY_START_DATE");

                entity.Property(e => e.ExternalLateEndDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("EXTERNAL_LATE_END_DATE");

                entity.Property(e => e.FloatPath).HasColumnName("FLOAT_PATH");

                entity.Property(e => e.FloatPathOrder).HasColumnName("FLOAT_PATH_ORDER");

                entity.Property(e => e.FreeFloatHrCnt).HasColumnName("FREE_FLOAT_HR_CNT");

                entity.Property(e => e.Guid)
                    .HasColumnType("TEXT(22)")
                    .HasColumnName("GUID");

                entity.Property(e => e.LateEndDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("LATE_END_DATE");

                entity.Property(e => e.LateStartDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("LATE_START_DATE");

                entity.Property(e => e.LocationId).HasColumnName("LOCATION_ID");

                entity.Property(e => e.LockPlanFlag)
                    .HasColumnType("TEXT(1)")
                    .HasColumnName("LOCK_PLAN_FLAG");

                entity.Property(e => e.PhysCompletePct).HasColumnName("PHYS_COMPLETE_PCT");

                entity.Property(e => e.PriorityType)
                    .HasColumnType("TEXT(12)")
                    .HasColumnName("PRIORITY_TYPE");

                entity.Property(e => e.ProjId).HasColumnName("PROJ_ID");

                entity.Property(e => e.ReendDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("REEND_DATE");

                entity.Property(e => e.RemLateEndDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("REM_LATE_END_DATE");

                entity.Property(e => e.RemLateStartDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("REM_LATE_START_DATE");

                entity.Property(e => e.RemainDrtnHrCnt).HasColumnName("REMAIN_DRTN_HR_CNT");

                entity.Property(e => e.RemainEquipQty).HasColumnName("REMAIN_EQUIP_QTY");

                entity.Property(e => e.RemainWorkQty).HasColumnName("REMAIN_WORK_QTY");

                entity.Property(e => e.RestartDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("RESTART_DATE");

                entity.Property(e => e.ResumeDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("RESUME_DATE");

                entity.Property(e => e.RevFdbkFlag)
                    .HasColumnType("TEXT(1)")
                    .HasColumnName("REV_FDBK_FLAG");

                entity.Property(e => e.RsrcId).HasColumnName("RSRC_ID");

                entity.Property(e => e.ScpPctComplete).HasColumnName("SCP_PCT_COMPLETE");

                entity.Property(e => e.StatusCode)
                    .HasColumnType("TEXT(12)")
                    .HasColumnName("STATUS_CODE");

                entity.Property(e => e.SuspendDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("SUSPEND_DATE");

                entity.Property(e => e.TargetDrtnHrCnt).HasColumnName("TARGET_DRTN_HR_CNT");

                entity.Property(e => e.TargetEndDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("TARGET_END_DATE");

                entity.Property(e => e.TargetEquipQty).HasColumnName("TARGET_EQUIP_QTY");

                entity.Property(e => e.TargetStartDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("TARGET_START_DATE");

                entity.Property(e => e.TargetWorkQty).HasColumnName("TARGET_WORK_QTY");

                entity.Property(e => e.TaskCode)
                    .HasColumnType("TEXT(40)")
                    .HasColumnName("TASK_CODE");

                entity.Property(e => e.TaskName)
                    .HasColumnType("TEXT(120)")
                    .HasColumnName("TASK_NAME");

                entity.Property(e => e.TaskType)
                    .HasColumnType("TEXT(10)")
                    .HasColumnName("TASK_TYPE");

                entity.Property(e => e.TmplGuid)
                    .HasColumnType("TEXT(22)")
                    .HasColumnName("TMPL_GUID");

                entity.Property(e => e.TotalFloatHrCnt).HasColumnName("TOTAL_FLOAT_HR_CNT");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.WbsId).HasColumnName("WBS_ID");
            });

            modelBuilder.Entity<Taskactv>(entity =>
            {
                entity.HasKey(e => new { e.TaskId, e.ActvCodeTypeId });

                entity.ToTable("TASKACTV");

                entity.HasIndex(e => e.ActvCodeId, "ndx_taskactv_actv_code_id");

                entity.HasIndex(e => e.ProjId, "ndx_taskactv_proj_id");

                entity.Property(e => e.TaskId).HasColumnName("TASK_ID");

                entity.Property(e => e.ActvCodeTypeId).HasColumnName("ACTV_CODE_TYPE_ID");

                entity.Property(e => e.ActvCodeId).HasColumnName("ACTV_CODE_ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.ProjId).HasColumnName("PROJ_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");
            });

            modelBuilder.Entity<Taskdoc>(entity =>
            {
                entity.ToTable("TASKDOC");

                entity.HasIndex(e => e.ProjId, "ndx_taskdoc_proj_id");

                entity.Property(e => e.TaskdocId)
                    .ValueGeneratedNever()
                    .HasColumnName("TASKDOC_ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.DocId).HasColumnName("DOC_ID");

                entity.Property(e => e.ProjId).HasColumnName("PROJ_ID");

                entity.Property(e => e.TaskId).HasColumnName("TASK_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.WbsId).HasColumnName("WBS_ID");

                entity.Property(e => e.WpFlag)
                    .HasColumnType("TEXT(1)")
                    .HasColumnName("WP_FLAG");
            });

            modelBuilder.Entity<Taskfdbk>(entity =>
            {
                entity.HasKey(e => e.TaskId);

                entity.ToTable("TASKFDBK");

                entity.HasIndex(e => e.ProjId, "ndx_taskfdbk_proj_id");

                entity.Property(e => e.TaskId)
                    .ValueGeneratedNever()
                    .HasColumnName("TASK_ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.ProjId).HasColumnName("PROJ_ID");

                entity.Property(e => e.TaskFdbk1).HasColumnName("TASK_FDBK");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");
            });

            modelBuilder.Entity<Taskfin>(entity =>
            {
                entity.HasKey(e => new { e.FinDatesId, e.TaskId });

                entity.ToTable("TASKFIN");

                entity.HasIndex(e => e.ProjId, "ndx_taskfin_proj_id");

                entity.Property(e => e.FinDatesId).HasColumnName("FIN_DATES_ID");

                entity.Property(e => e.TaskId).HasColumnName("TASK_ID");

                entity.Property(e => e.ActEquipCost).HasColumnName("ACT_EQUIP_COST");

                entity.Property(e => e.ActEquipQty).HasColumnName("ACT_EQUIP_QTY");

                entity.Property(e => e.ActExpenseCost).HasColumnName("ACT_EXPENSE_COST");

                entity.Property(e => e.ActMatCost).HasColumnName("ACT_MAT_COST");

                entity.Property(e => e.ActWorkCost).HasColumnName("ACT_WORK_COST");

                entity.Property(e => e.ActWorkQty).HasColumnName("ACT_WORK_QTY");

                entity.Property(e => e.Bcwp).HasColumnName("BCWP");

                entity.Property(e => e.Bcws).HasColumnName("BCWS");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.PerfmWorkQty).HasColumnName("PERFM_WORK_QTY");

                entity.Property(e => e.ProjId).HasColumnName("PROJ_ID");

                entity.Property(e => e.SchedWorkQty).HasColumnName("SCHED_WORK_QTY");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");
            });

            modelBuilder.Entity<Taskmemo>(entity =>
            {
                entity.HasKey(e => e.MemoId);

                entity.ToTable("TASKMEMO");

                entity.HasIndex(e => e.ProjId, "ndx_taskmemo_proj_id");

                entity.Property(e => e.MemoId)
                    .ValueGeneratedNever()
                    .HasColumnName("MEMO_ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.MemoTypeId).HasColumnName("MEMO_TYPE_ID");

                entity.Property(e => e.ProjId).HasColumnName("PROJ_ID");

                entity.Property(e => e.TaskId).HasColumnName("TASK_ID");

                entity.Property(e => e.TaskMemo1).HasColumnName("TASK_MEMO");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");
            });

            modelBuilder.Entity<Tasknote>(entity =>
            {
                entity.HasKey(e => e.TaskId);

                entity.ToTable("TASKNOTE");

                entity.HasIndex(e => e.ProjId, "ndx_tasknote_proj_id");

                entity.Property(e => e.TaskId)
                    .ValueGeneratedNever()
                    .HasColumnName("TASK_ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.ProjId).HasColumnName("PROJ_ID");

                entity.Property(e => e.TaskNotes).HasColumnName("TASK_NOTES");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");
            });

            modelBuilder.Entity<Taskpred>(entity =>
            {
                entity.ToTable("TASKPRED");

                entity.HasIndex(e => e.PredProjId, "ndx_taskpred_pred_proj_id");

                entity.HasIndex(e => e.ProjId, "ndx_taskpred_proj_id");

                entity.Property(e => e.TaskPredId)
                    .ValueGeneratedNever()
                    .HasColumnName("TASK_PRED_ID");

                entity.Property(e => e.Comments)
                    .HasColumnType("TEXT(250)")
                    .HasColumnName("COMMENTS");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.LagHrCnt).HasColumnName("LAG_HR_CNT");

                entity.Property(e => e.PredProjId).HasColumnName("PRED_PROJ_ID");

                entity.Property(e => e.PredTaskId).HasColumnName("PRED_TASK_ID");

                entity.Property(e => e.PredType)
                    .HasColumnType("TEXT(12)")
                    .HasColumnName("PRED_TYPE");

                entity.Property(e => e.ProjId).HasColumnName("PROJ_ID");

                entity.Property(e => e.TaskId).HasColumnName("TASK_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");
            });

            modelBuilder.Entity<Taskproc>(entity =>
            {
                entity.HasKey(e => e.ProcId);

                entity.ToTable("TASKPROC");

                entity.HasIndex(e => e.ProjId, "ndx_taskproc_proj_id");

                entity.Property(e => e.ProcId)
                    .ValueGeneratedNever()
                    .HasColumnName("PROC_ID");

                entity.Property(e => e.CompleteFlag)
                    .HasColumnType("TEXT(1)")
                    .HasColumnName("COMPLETE_FLAG");

                entity.Property(e => e.CompletePct).HasColumnName("COMPLETE_PCT");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.ProcDescr).HasColumnName("PROC_DESCR");

                entity.Property(e => e.ProcName)
                    .HasColumnType("TEXT(120)")
                    .HasColumnName("PROC_NAME");

                entity.Property(e => e.ProcWt).HasColumnName("PROC_WT");

                entity.Property(e => e.ProjId).HasColumnName("PROJ_ID");

                entity.Property(e => e.SeqNum).HasColumnName("SEQ_NUM");

                entity.Property(e => e.TaskId).HasColumnName("TASK_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");
            });

            modelBuilder.Entity<Taskrisk>(entity =>
            {
                entity.HasKey(e => new { e.RiskId, e.TaskId });

                entity.ToTable("TASKRISK");

                entity.HasIndex(e => e.ProjId, "ndx_taskrisk_proj_id");

                entity.Property(e => e.RiskId).HasColumnName("RISK_ID");

                entity.Property(e => e.TaskId).HasColumnName("TASK_ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.ProjId).HasColumnName("PROJ_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");
            });

            modelBuilder.Entity<Taskrsrc>(entity =>
            {
                entity.ToTable("TASKRSRC");

                entity.HasIndex(e => e.ProjId, "ndx_taskrsrc_proj_id");

                entity.Property(e => e.TaskrsrcId)
                    .ValueGeneratedNever()
                    .HasColumnName("TASKRSRC_ID");

                entity.Property(e => e.AcctId).HasColumnName("ACCT_ID");

                entity.Property(e => e.ActEndDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("ACT_END_DATE");

                entity.Property(e => e.ActOtCost).HasColumnName("ACT_OT_COST");

                entity.Property(e => e.ActOtQty).HasColumnName("ACT_OT_QTY");

                entity.Property(e => e.ActRegCost).HasColumnName("ACT_REG_COST");

                entity.Property(e => e.ActRegQty).HasColumnName("ACT_REG_QTY");

                entity.Property(e => e.ActStartDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("ACT_START_DATE");

                entity.Property(e => e.ActThisPerCost).HasColumnName("ACT_THIS_PER_COST");

                entity.Property(e => e.ActThisPerQty).HasColumnName("ACT_THIS_PER_QTY");

                entity.Property(e => e.ActualCrv)
                    .HasColumnType("TEXT(4000)")
                    .HasColumnName("ACTUAL_CRV");

                entity.Property(e => e.CostPerQty).HasColumnName("COST_PER_QTY");

                entity.Property(e => e.CostPerQtySourceType)
                    .HasColumnType("TEXT(24)")
                    .HasColumnName("COST_PER_QTY_SOURCE_TYPE");

                entity.Property(e => e.CostQtyLinkFlag)
                    .HasColumnType("TEXT(1)")
                    .HasColumnName("COST_QTY_LINK_FLAG");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.CurvId).HasColumnName("CURV_ID");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.Guid)
                    .HasColumnType("TEXT(22)")
                    .HasColumnName("GUID");

                entity.Property(e => e.OtFactor).HasColumnName("OT_FACTOR");

                entity.Property(e => e.PobsId).HasColumnName("POBS_ID");

                entity.Property(e => e.ProjId).HasColumnName("PROJ_ID");

                entity.Property(e => e.RateType)
                    .HasColumnType("TEXT(14)")
                    .HasColumnName("RATE_TYPE");

                entity.Property(e => e.ReendDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("REEND_DATE");

                entity.Property(e => e.RelagDrtnHrCnt).HasColumnName("RELAG_DRTN_HR_CNT");

                entity.Property(e => e.RemLateEndDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("REM_LATE_END_DATE");

                entity.Property(e => e.RemLateStartDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("REM_LATE_START_DATE");

                entity.Property(e => e.RemainCost).HasColumnName("REMAIN_COST");

                entity.Property(e => e.RemainCrv)
                    .HasColumnType("TEXT(4000)")
                    .HasColumnName("REMAIN_CRV");

                entity.Property(e => e.RemainQty).HasColumnName("REMAIN_QTY");

                entity.Property(e => e.RemainQtyPerHr).HasColumnName("REMAIN_QTY_PER_HR");

                entity.Property(e => e.RestartDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("RESTART_DATE");

                entity.Property(e => e.RoleId).HasColumnName("ROLE_ID");

                entity.Property(e => e.RollupDatesFlag)
                    .HasColumnType("TEXT(1)")
                    .HasColumnName("ROLLUP_DATES_FLAG");

                entity.Property(e => e.RsrcId).HasColumnName("RSRC_ID");

                entity.Property(e => e.RsrcType)
                    .HasColumnType("TEXT(10)")
                    .HasColumnName("RSRC_TYPE");

                entity.Property(e => e.SkillLevel).HasColumnName("SKILL_LEVEL");

                entity.Property(e => e.TargetCost).HasColumnName("TARGET_COST");

                entity.Property(e => e.TargetCrv)
                    .HasColumnType("TEXT(4000)")
                    .HasColumnName("TARGET_CRV");

                entity.Property(e => e.TargetEndDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("TARGET_END_DATE");

                entity.Property(e => e.TargetLagDrtnHrCnt).HasColumnName("TARGET_LAG_DRTN_HR_CNT");

                entity.Property(e => e.TargetQty).HasColumnName("TARGET_QTY");

                entity.Property(e => e.TargetQtyPerHr).HasColumnName("TARGET_QTY_PER_HR");

                entity.Property(e => e.TargetStartDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("TARGET_START_DATE");

                entity.Property(e => e.TaskId).HasColumnName("TASK_ID");

                entity.Property(e => e.TsPendActEndFlag)
                    .HasColumnType("TEXT(1)")
                    .HasColumnName("TS_PEND_ACT_END_FLAG");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");
            });

            modelBuilder.Entity<Taskuser>(entity =>
            {
                entity.HasKey(e => new { e.TaskId, e.UserId });

                entity.ToTable("TASKUSER");

                entity.HasIndex(e => e.ProjId, "ndx_taskuser_proj_id");

                entity.Property(e => e.TaskId).HasColumnName("TASK_ID");

                entity.Property(e => e.UserId).HasColumnName("USER_ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.ProjId).HasColumnName("PROJ_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");
            });

            modelBuilder.Entity<Thrsparm>(entity =>
            {
                entity.HasKey(e => e.ThreshParmId);

                entity.ToTable("THRSPARM");

                entity.Property(e => e.ThreshParmId)
                    .ValueGeneratedNever()
                    .HasColumnName("THRESH_PARM_ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.RsrcFlag)
                    .HasColumnType("TEXT(1)")
                    .HasColumnName("RSRC_FLAG");

                entity.Property(e => e.SeqNum).HasColumnName("SEQ_NUM");

                entity.Property(e => e.TaskFlag)
                    .HasColumnType("TEXT(1)")
                    .HasColumnName("TASK_FLAG");

                entity.Property(e => e.ThreshFieldName)
                    .HasColumnType("TEXT(40)")
                    .HasColumnName("THRESH_FIELD_NAME");

                entity.Property(e => e.ThreshParmName)
                    .HasColumnType("TEXT(80)")
                    .HasColumnName("THRESH_PARM_NAME");

                entity.Property(e => e.ThreshParmType)
                    .HasColumnType("TEXT(12)")
                    .HasColumnName("THRESH_PARM_TYPE");

                entity.Property(e => e.ThreshShortName)
                    .HasColumnType("TEXT(80)")
                    .HasColumnName("THRESH_SHORT_NAME");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.WbsFlag)
                    .HasColumnType("TEXT(1)")
                    .HasColumnName("WBS_FLAG");
            });

            modelBuilder.Entity<Trakview>(entity =>
            {
                entity.HasKey(e => e.TrackViewId);

                entity.ToTable("TRAKVIEW");

                entity.Property(e => e.TrackViewId)
                    .ValueGeneratedNever()
                    .HasColumnName("TRACK_VIEW_ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.DisplayType)
                    .HasColumnType("TEXT(12)")
                    .HasColumnName("DISPLAY_TYPE");

                entity.Property(e => e.TrackViewData).HasColumnName("TRACK_VIEW_DATA");

                entity.Property(e => e.TrackViewName)
                    .HasColumnType("TEXT(80)")
                    .HasColumnName("TRACK_VIEW_NAME");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.UserId).HasColumnName("USER_ID");

                entity.Property(e => e.WebViewFlag)
                    .HasColumnType("TEXT(1)")
                    .HasColumnName("WEB_VIEW_FLAG");
            });

            modelBuilder.Entity<Trsrcfin>(entity =>
            {
                entity.HasKey(e => new { e.FinDatesId, e.TaskrsrcId });

                entity.ToTable("TRSRCFIN");

                entity.HasIndex(e => e.ProjId, "ndx_trsrcfin_proj_id");

                entity.Property(e => e.FinDatesId).HasColumnName("FIN_DATES_ID");

                entity.Property(e => e.TaskrsrcId).HasColumnName("TASKRSRC_ID");

                entity.Property(e => e.ActCost).HasColumnName("ACT_COST");

                entity.Property(e => e.ActQty).HasColumnName("ACT_QTY");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.ProjId).HasColumnName("PROJ_ID");

                entity.Property(e => e.TaskId).HasColumnName("TASK_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");
            });

            modelBuilder.Entity<Udfcode>(entity =>
            {
                entity.ToTable("UDFCODE");

                entity.Property(e => e.UdfCodeId)
                    .ValueGeneratedNever()
                    .HasColumnName("UDF_CODE_ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.ShortName)
                    .HasColumnType("TEXT(60)")
                    .HasColumnName("SHORT_NAME");

                entity.Property(e => e.UdfCodeName)
                    .HasColumnType("TEXT(120)")
                    .HasColumnName("UDF_CODE_NAME");

                entity.Property(e => e.UdfTypeId).HasColumnName("UDF_TYPE_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");
            });

            modelBuilder.Entity<Udftype>(entity =>
            {
                entity.ToTable("UDFTYPE");

                entity.Property(e => e.UdfTypeId)
                    .ValueGeneratedNever()
                    .HasColumnName("UDF_TYPE_ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.Formula)
                    .HasColumnType("TEXT(4000)")
                    .HasColumnName("FORMULA");

                entity.Property(e => e.IndicatorExpression)
                    .HasColumnType("TEXT(4000)")
                    .HasColumnName("INDICATOR_EXPRESSION");

                entity.Property(e => e.LogicalDataType)
                    .HasColumnType("TEXT(20)")
                    .HasColumnName("LOGICAL_DATA_TYPE");

                entity.Property(e => e.SummaryIndicatorExpression)
                    .HasColumnType("TEXT(4000)")
                    .HasColumnName("SUMMARY_INDICATOR_EXPRESSION");

                entity.Property(e => e.SuperFlag)
                    .HasColumnType("TEXT(1)")
                    .HasColumnName("SUPER_FLAG");

                entity.Property(e => e.TableName)
                    .HasColumnType("TEXT(30)")
                    .HasColumnName("TABLE_NAME");

                entity.Property(e => e.UdfTypeLabel)
                    .HasColumnType("TEXT(40)")
                    .HasColumnName("UDF_TYPE_LABEL");

                entity.Property(e => e.UdfTypeName)
                    .HasColumnType("TEXT(32)")
                    .HasColumnName("UDF_TYPE_NAME");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");
            });

            modelBuilder.Entity<Udfvalue>(entity =>
            {
                entity.HasKey(e => new { e.UdfTypeId, e.FkId });

                entity.ToTable("UDFVALUE");

                entity.HasIndex(e => e.ProjId, "ndx_udfvalue_proj_id");

                entity.Property(e => e.UdfTypeId).HasColumnName("UDF_TYPE_ID");

                entity.Property(e => e.FkId).HasColumnName("FK_ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.ProjId).HasColumnName("PROJ_ID");

                entity.Property(e => e.TableName)
                    .HasColumnType("TEXT(30)")
                    .HasColumnName("TABLE_NAME");

                entity.Property(e => e.UdfCodeId).HasColumnName("UDF_CODE_ID");

                entity.Property(e => e.UdfDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UDF_DATE");

                entity.Property(e => e.UdfNumber).HasColumnName("UDF_NUMBER");

                entity.Property(e => e.UdfText)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UDF_TEXT");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");
            });

            modelBuilder.Entity<Umeasure>(entity =>
            {
                entity.HasKey(e => e.UnitId);

                entity.ToTable("UMEASURE");

                entity.Property(e => e.UnitId)
                    .ValueGeneratedNever()
                    .HasColumnName("UNIT_ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.SeqNum).HasColumnName("SEQ_NUM");

                entity.Property(e => e.UnitAbbrev)
                    .HasColumnType("TEXT(16)")
                    .HasColumnName("UNIT_ABBREV");

                entity.Property(e => e.UnitName)
                    .HasColumnType("TEXT(100)")
                    .HasColumnName("UNIT_NAME");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("USERS");

                entity.Property(e => e.UserId)
                    .ValueGeneratedNever()
                    .HasColumnName("USER_ID");

                entity.Property(e => e.ActualName)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("ACTUAL_NAME");

                entity.Property(e => e.AllRsrcAccessFlag)
                    .HasColumnType("TEXT(1)")
                    .HasColumnName("ALL_RSRC_ACCESS_FLAG");

                entity.Property(e => e.CrExternalKey)
                    .HasColumnType("TEXT(4000)")
                    .HasColumnName("CR_EXTERNAL_KEY");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.CurrId).HasColumnName("CURR_ID");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.EmailAddr)
                    .HasColumnType("TEXT(120)")
                    .HasColumnName("EMAIL_ADDR");

                entity.Property(e => e.EmailSendServer)
                    .HasColumnType("TEXT(120)")
                    .HasColumnName("EMAIL_SEND_SERVER");

                entity.Property(e => e.EmailSrvPasswd)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("EMAIL_SRV_PASSWD");

                entity.Property(e => e.EmailSrvUserName)
                    .HasColumnType("TEXT(32)")
                    .HasColumnName("EMAIL_SRV_USER_NAME");

                entity.Property(e => e.EmailType)
                    .HasColumnType("TEXT(16)")
                    .HasColumnName("EMAIL_TYPE");

                entity.Property(e => e.GlobalFlag)
                    .HasColumnType("TEXT(1)")
                    .HasColumnName("GLOBAL_FLAG");

                entity.Property(e => e.Guid)
                    .HasColumnType("TEXT(22)")
                    .HasColumnName("GUID");

                entity.Property(e => e.OfficePhone)
                    .HasColumnType("TEXT(32)")
                    .HasColumnName("OFFICE_PHONE");

                entity.Property(e => e.Passwd)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("PASSWD");

                entity.Property(e => e.ProfId).HasColumnName("PROF_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.UserName)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("USER_NAME");
            });

            modelBuilder.Entity<Usercol>(entity =>
            {
                entity.ToTable("USERCOL");

                entity.Property(e => e.UserColId)
                    .ValueGeneratedNever()
                    .HasColumnName("USER_COL_ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.LogicalDataType)
                    .HasColumnType("TEXT(20)")
                    .HasColumnName("LOGICAL_DATA_TYPE");

                entity.Property(e => e.TableName)
                    .HasColumnType("TEXT(16)")
                    .HasColumnName("TABLE_NAME");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.UserColLabel)
                    .HasColumnType("TEXT(40)")
                    .HasColumnName("USER_COL_LABEL");

                entity.Property(e => e.UserColName)
                    .HasColumnType("TEXT(32)")
                    .HasColumnName("USER_COL_NAME");
            });

            modelBuilder.Entity<Userdatum>(entity =>
            {
                entity.HasKey(e => e.UserDataId);

                entity.ToTable("USERDATA");

                entity.Property(e => e.UserDataId)
                    .ValueGeneratedNever()
                    .HasColumnName("USER_DATA_ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.TopicName)
                    .HasColumnType("TEXT(20)")
                    .HasColumnName("TOPIC_NAME");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.UserData).HasColumnName("USER_DATA");

                entity.Property(e => e.UserId).HasColumnName("USER_ID");
            });

            modelBuilder.Entity<Usereng>(entity =>
            {
                entity.ToTable("USERENG");

                entity.Property(e => e.UserEngId)
                    .ValueGeneratedNever()
                    .HasColumnName("USER_ENG_ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.DbEngineType)
                    .HasColumnType("TEXT(20)")
                    .HasColumnName("DB_ENGINE_TYPE");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.UserId).HasColumnName("USER_ID");
            });

            modelBuilder.Entity<Userob>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.ObsId });

                entity.ToTable("USEROBS");

                entity.Property(e => e.UserId).HasColumnName("USER_ID");

                entity.Property(e => e.ObsId).HasColumnName("OBS_ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.ProfId).HasColumnName("PROF_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");
            });

            modelBuilder.Entity<Userset>(entity =>
            {
                entity.HasKey(e => new { e.Namespace, e.SettingName, e.UserId });

                entity.ToTable("USERSET");

                entity.Property(e => e.Namespace)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("NAMESPACE");

                entity.Property(e => e.SettingName)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("SETTING_NAME");

                entity.Property(e => e.UserId).HasColumnName("USER_ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.SettingValue)
                    .HasColumnType("TEXT(4000)")
                    .HasColumnName("SETTING_VALUE");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.UsersetBlob).HasColumnName("USERSET_BLOB");
            });

            modelBuilder.Entity<Usession>(entity =>
            {
                entity.HasKey(e => e.SessionId);

                entity.ToTable("USESSION");

                entity.Property(e => e.SessionId)
                    .ValueGeneratedNever()
                    .HasColumnName("SESSION_ID");

                entity.Property(e => e.AppName)
                    .HasColumnType("TEXT(25)")
                    .HasColumnName("APP_NAME");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.DbEngineType)
                    .HasColumnType("TEXT(20)")
                    .HasColumnName("DB_ENGINE_TYPE");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.HardDriveCode)
                    .HasColumnType("TEXT(40)")
                    .HasColumnName("HARD_DRIVE_CODE");

                entity.Property(e => e.HostName)
                    .HasColumnType("TEXT(50)")
                    .HasColumnName("HOST_NAME");

                entity.Property(e => e.LastActiveTime)
                    .HasColumnType("DATETIME")
                    .HasColumnName("LAST_ACTIVE_TIME");

                entity.Property(e => e.LoginTime)
                    .HasColumnType("DATETIME")
                    .HasColumnName("LOGIN_TIME");

                entity.Property(e => e.OsUserName)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("OS_USER_NAME");

                entity.Property(e => e.ProcessNum).HasColumnName("PROCESS_NUM");

                entity.Property(e => e.Spid).HasColumnName("SPID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.UserId).HasColumnName("USER_ID");

                entity.Property(e => e.VdbInstanceGuid)
                    .HasColumnType("TEXT(22)")
                    .HasColumnName("VDB_INSTANCE_GUID");
            });

            modelBuilder.Entity<Viewprop>(entity =>
            {
                entity.HasKey(e => e.ViewId);

                entity.ToTable("VIEWPROP");

                entity.HasIndex(e => e.ProjId, "ndx_viewprop_proj_id");

                entity.Property(e => e.ViewId)
                    .ValueGeneratedNever()
                    .HasColumnName("VIEW_ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.ProjId).HasColumnName("PROJ_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.UserId).HasColumnName("USER_ID");

                entity.Property(e => e.ViewData).HasColumnName("VIEW_DATA");

                entity.Property(e => e.ViewName)
                    .HasColumnType("TEXT(40)")
                    .HasColumnName("VIEW_NAME");

                entity.Property(e => e.ViewType)
                    .HasColumnType("TEXT(20)")
                    .HasColumnName("VIEW_TYPE");
            });

            modelBuilder.Entity<Wbrscat>(entity =>
            {
                entity.ToTable("WBRSCAT");

                entity.Property(e => e.WbrsCatId)
                    .ValueGeneratedNever()
                    .HasColumnName("WBRS_CAT_ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.WbrsCatName)
                    .HasColumnType("TEXT(36)")
                    .HasColumnName("WBRS_CAT_NAME");
            });

            modelBuilder.Entity<Wbsbudg>(entity =>
            {
                entity.ToTable("WBSBUDG");

                entity.HasIndex(e => e.ProjId, "ndx_wbsbudg_proj_id");

                entity.Property(e => e.WbsBudgId)
                    .ValueGeneratedNever()
                    .HasColumnName("WBS_BUDG_ID");

                entity.Property(e => e.BenefitCost).HasColumnName("BENEFIT_COST");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.ProjId).HasColumnName("PROJ_ID");

                entity.Property(e => e.SpendCost).HasColumnName("SPEND_COST");

                entity.Property(e => e.StartDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("START_DATE");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.WbsId).HasColumnName("WBS_ID");
            });

            modelBuilder.Entity<Wbsmemo>(entity =>
            {
                entity.ToTable("WBSMEMO");

                entity.HasIndex(e => e.ProjId, "ndx_wbsmemo_proj_id");

                entity.Property(e => e.WbsMemoId)
                    .ValueGeneratedNever()
                    .HasColumnName("WBS_MEMO_ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.MemoTypeId).HasColumnName("MEMO_TYPE_ID");

                entity.Property(e => e.ProjId).HasColumnName("PROJ_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.WbsId).HasColumnName("WBS_ID");

                entity.Property(e => e.WbsMemo1).HasColumnName("WBS_MEMO");
            });

            modelBuilder.Entity<Wbsrsrc>(entity =>
            {
                entity.ToTable("WBSRSRC");

                entity.HasIndex(e => e.ProjId, "ndx_wbsrsrc_proj_id");

                entity.Property(e => e.WbsrsrcId)
                    .ValueGeneratedNever()
                    .HasColumnName("WBSRSRC_ID");

                entity.Property(e => e.AutoComputeDatesFlag)
                    .HasColumnType("TEXT(1)")
                    .HasColumnName("AUTO_COMPUTE_DATES_FLAG");

                entity.Property(e => e.CommittedFlag)
                    .HasColumnType("TEXT(1)")
                    .HasColumnName("COMMITTED_FLAG");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.EndDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("END_DATE");

                entity.Property(e => e.ProjId).HasColumnName("PROJ_ID");

                entity.Property(e => e.RoleId).HasColumnName("ROLE_ID");

                entity.Property(e => e.RsrcId).HasColumnName("RSRC_ID");

                entity.Property(e => e.RsrcRequestData)
                    .HasColumnType("TEXT(4000)")
                    .HasColumnName("RSRC_REQUEST_DATA");

                entity.Property(e => e.StartDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("START_DATE");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.WbrsCatId).HasColumnName("WBRS_CAT_ID");

                entity.Property(e => e.WbsId).HasColumnName("WBS_ID");
            });

            modelBuilder.Entity<WbsrsrcQty>(entity =>
            {
                entity.HasKey(e => new { e.WbsrsrcId, e.WeekStart, e.MonthStart });

                entity.ToTable("WBSRSRC_QTY");

                entity.Property(e => e.WbsrsrcId).HasColumnName("WBSRSRC_ID");

                entity.Property(e => e.WeekStart)
                    .HasColumnType("DATETIME")
                    .HasColumnName("WEEK_START");

                entity.Property(e => e.MonthStart)
                    .HasColumnType("DATETIME")
                    .HasColumnName("MONTH_START");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.FinDatesId1).HasColumnName("FIN_DATES_ID1");

                entity.Property(e => e.FinDatesId2).HasColumnName("FIN_DATES_ID2");

                entity.Property(e => e.FinQty1).HasColumnName("FIN_QTY1");

                entity.Property(e => e.FinQty2).HasColumnName("FIN_QTY2");

                entity.Property(e => e.Qty).HasColumnName("QTY");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");
            });

            modelBuilder.Entity<Wbsstep>(entity =>
            {
                entity.ToTable("WBSSTEP");

                entity.HasIndex(e => e.ProjId, "ndx_wbsstep_proj_id");

                entity.Property(e => e.WbsStepId)
                    .ValueGeneratedNever()
                    .HasColumnName("WBS_STEP_ID");

                entity.Property(e => e.CompleteFlag)
                    .HasColumnType("TEXT(1)")
                    .HasColumnName("COMPLETE_FLAG");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("CREATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId).HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.ProjId).HasColumnName("PROJ_ID");

                entity.Property(e => e.SeqNum).HasColumnName("SEQ_NUM");

                entity.Property(e => e.StepName)
                    .HasColumnType("TEXT(120)")
                    .HasColumnName("STEP_NAME");

                entity.Property(e => e.StepWt).HasColumnName("STEP_WT");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATETIME")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasColumnType("TEXT(255)")
                    .HasColumnName("UPDATE_USER")
                    .HasDefaultValueSql("'NotPrmUser'");

                entity.Property(e => e.WbsId).HasColumnName("WBS_ID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
