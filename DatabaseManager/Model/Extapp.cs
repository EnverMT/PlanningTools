namespace DatabaseManager.Model
{
    public partial class Extapp
    {
        public long AppId { get; set; }
        public string? LoginSupplyFlag { get; set; }
        public string? AppName { get; set; }
        public string? AppExeName { get; set; }
        public long? ProjId { get; set; }
        public string? AppUserName { get; set; }
        public string? AppPasswd { get; set; }
        public string? AppDataName { get; set; }
        public string? AppParmString { get; set; }
        public string? AppDataLoc { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public long? DeleteSessionId { get; set; }
        public DateTime? DeleteDate { get; set; }

        //Original names in db have "_"
    }
}
