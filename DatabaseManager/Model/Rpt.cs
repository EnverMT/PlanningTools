namespace DatabaseManager.Model
{
    public partial class Rpt
    {
        public long RptId { get; set; }
        public long? RptGroupId { get; set; }
        public string? RptType { get; set; }
        public string? RptName { get; set; }
        public string? GlobalFlag { get; set; }
        public long? ProjId { get; set; }
        public string? RptState { get; set; }
        public byte[]? LastRunDate { get; set; }
        public string? RptArea { get; set; }
        public long? UserId { get; set; }
        public byte[]? RptData { get; set; }
        public byte[]? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public byte[]? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public long? DeleteSessionId { get; set; }
        public byte[]? DeleteDate { get; set; }
    }
}
