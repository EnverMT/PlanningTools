namespace DatabaseManager.Model
{
    public partial class Jobsvc
    {
        public long JobId { get; set; }
        public long? SeqNum { get; set; }
        public string? AuditFlag { get; set; }
        public string? JobType { get; set; }
        public string? JobName { get; set; }
        public long? UserId { get; set; }
        public DateTime? LastRunDate { get; set; }
        public string? StatusCode { get; set; }
        public string? RecurData { get; set; }
        public string? RecurType { get; set; }
        public string? LastErrorDescr { get; set; }
        public DateTime? SubmittedDate { get; set; }
        public string? AuditFilePath { get; set; }
        public byte[]? JobData { get; set; }
        public long? ParentJobId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public long? DeleteSessionId { get; set; }
        public DateTime? DeleteDate { get; set; }
    }
}
