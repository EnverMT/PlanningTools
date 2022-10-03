namespace DatabaseManager.Model
{
    public partial class Rolerate
    {
        public long RoleRateId { get; set; }
        public long? RoleId { get; set; }
        public double? CostPerQty { get; set; }
        public double? CostPerQty2 { get; set; }
        public double? CostPerQty3 { get; set; }
        public double? CostPerQty4 { get; set; }
        public double? CostPerQty5 { get; set; }
        public byte[]? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public byte[]? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public long? DeleteSessionId { get; set; }
        public byte[]? DeleteDate { get; set; }
        public byte[]? StartDate { get; set; }
        public double? MaxQtyPerHr { get; set; }
    }
}
