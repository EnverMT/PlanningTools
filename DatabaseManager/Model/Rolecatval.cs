namespace DatabaseManager.Model
{
    public partial class Rolecatval
    {
        public long RoleCatgId { get; set; }
        public long RoleCatgTypeId { get; set; }
        public long? SeqNum { get; set; }
        public string? RoleCatgShortName { get; set; }
        public string? RoleCatgName { get; set; }
        public long? ParentRoleCatgId { get; set; }
        public byte[]? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public byte[]? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public long? DeleteSessionId { get; set; }
        public byte[]? DeleteDate { get; set; }
    }
}
