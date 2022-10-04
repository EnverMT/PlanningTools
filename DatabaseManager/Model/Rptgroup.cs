namespace DatabaseManager.Model
{
    public partial class Rptgroup
    {
        public long RptGroupId { get; set; }
        public long? RptGroupSeqNum { get; set; }
        public string? RptGroupName { get; set; }
        public long? ParentGroupId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public long? DeleteSessionId { get; set; }
        public DateTime? DeleteDate { get; set; }
    }
}
