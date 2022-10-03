namespace DatabaseManager.Model
{
    public partial class Pcatval
    {
        public long ProjCatgId { get; set; }
        public long? ProjCatgTypeId { get; set; }
        public long? SeqNum { get; set; }
        public string? ProjCatgShortName { get; set; }
        public long? ParentProjCatgId { get; set; }
        public string? ProjCatgName { get; set; }
        public byte[]? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public byte[]? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public long? DeleteSessionId { get; set; }
        public byte[]? DeleteDate { get; set; }
    }
}
