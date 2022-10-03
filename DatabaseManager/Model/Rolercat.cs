namespace DatabaseManager.Model
{
    public partial class Rolercat
    {
        public long RoleId { get; set; }
        public long RoleCatgTypeId { get; set; }
        public long RoleCatgId { get; set; }
        public byte[]? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public byte[]? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public long? DeleteSessionId { get; set; }
        public byte[]? DeleteDate { get; set; }
    }
}
