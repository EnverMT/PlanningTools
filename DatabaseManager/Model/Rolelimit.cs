namespace DatabaseManager.Model
{
    public partial class Rolelimit
    {
        public long RolelimitId { get; set; }
        public long? RoleId { get; set; }
        public DateTime? StartDate { get; set; }
        public double? MaxQtyPerHr { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public long? DeleteSessionId { get; set; }
        public DateTime? DeleteDate { get; set; }
    }
}
