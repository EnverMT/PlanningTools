namespace DatabaseManager.Model
{
    public partial class Rolelimit
    {
        public long RolelimitId { get; set; }
        public long? RoleId { get; set; }
        public byte[]? StartDate { get; set; }
        public double? MaxQtyPerHr { get; set; }
        public byte[]? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public byte[]? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public long? DeleteSessionId { get; set; }
        public byte[]? DeleteDate { get; set; }
    }
}
