namespace DatabaseManager.Model
{
    public partial class WbsrsrcQty
    {
        public long WbsrsrcId { get; set; }
        public DateTime? WeekStart { get; set; } = null!;
        public DateTime? MonthStart { get; set; } = null!;
        public double? Qty { get; set; }
        public long? FinDatesId1 { get; set; }
        public double? FinQty1 { get; set; }
        public long? FinDatesId2 { get; set; }
        public double? FinQty2 { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public long? DeleteSessionId { get; set; }
        public DateTime? DeleteDate { get; set; }
    }
}
