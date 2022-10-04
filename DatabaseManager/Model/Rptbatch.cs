namespace DatabaseManager.Model
{
    public partial class Rptbatch
    {
        public long RptBatchId { get; set; }
        public string? RptBatchName { get; set; }
        public long? ProjId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public long? DeleteSessionId { get; set; }
        public DateTime? DeleteDate { get; set; }
    }
}
