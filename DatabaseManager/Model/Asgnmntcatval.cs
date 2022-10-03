namespace DatabaseManager.Model
{
    public partial class Asgnmntcatval
    {
        public long AsgnmntCatgId { get; set; }
        public long AsgnmntCatgTypeId { get; set; }
        public long? SeqNum { get; set; }
        public string? AsgnmntCatgShortName { get; set; }
        public string? AsgnmntCatgName { get; set; }
        public long? ParentAsgnmntCatgId { get; set; }
        public byte[]? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public byte[]? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public long? DeleteSessionId { get; set; }
        public byte[]? DeleteDate { get; set; }
    }
}
