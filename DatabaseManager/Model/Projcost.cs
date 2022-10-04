namespace DatabaseManager.Model
{
    public partial class Projcost
    {
        public long CostItemId { get; set; }
        public long? AcctId { get; set; }
        public long? PobsId { get; set; }
        public long? CostTypeId { get; set; }
        public long? ProjId { get; set; }
        public long? TaskId { get; set; }
        public string? CostName { get; set; }
        public string? PoNumber { get; set; }
        public string? VendorName { get; set; }
        public double? ActCost { get; set; }
        public double? CostPerQty { get; set; }
        public double? RemainCost { get; set; }
        public double? TargetCost { get; set; }
        public string? CostLoadType { get; set; }
        public string? AutoComputeActFlag { get; set; }
        public double? TargetQty { get; set; }
        public string? QtyName { get; set; }
        public byte[]? CostDescr { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public long? DeleteSessionId { get; set; }
        public DateTime? DeleteDate { get; set; }
    }
}
