namespace DatabaseManager.Model
{
    public partial class Projest
    {
        public long ProjEstId { get; set; }
        public long? ProjId { get; set; }
        public long? RsrcId { get; set; }
        public long? WbsId { get; set; }
        public string? EstName { get; set; }
        public double? EstQty { get; set; }
        public DateTime? EstDate { get; set; }
        public string? EstType { get; set; }
        public string? AppliedFlag { get; set; }
        public long? AdjMultPct { get; set; }
        public long? BuCmplxValue { get; set; }
        public long? EstTaskCnt { get; set; }
        public long? FpCmplxValue { get; set; }
        public long? FpCnt { get; set; }
        public double? FpProdAvgValue { get; set; }
        public long? FpUnadjCnt { get; set; }
        public string? RsrcType { get; set; }
        public byte[]? EstNotes { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public long? DeleteSessionId { get; set; }
        public DateTime? DeleteDate { get; set; }
    }
}
