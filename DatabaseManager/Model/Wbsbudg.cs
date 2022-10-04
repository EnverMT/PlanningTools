namespace DatabaseManager.Model
{
    public partial class Wbsbudg
    {
        public long WbsBudgId { get; set; }
        public long? ProjId { get; set; }
        public long? WbsId { get; set; }
        public DateTime? StartDate { get; set; }
        public double? SpendCost { get; set; }
        public double? BenefitCost { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public long? DeleteSessionId { get; set; }
        public DateTime? DeleteDate { get; set; }
    }
}
