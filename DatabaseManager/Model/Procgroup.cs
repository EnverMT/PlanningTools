namespace DatabaseManager.Model
{
    public partial class Procgroup
    {
        public long ProcGroupId { get; set; }
        public long? SeqNum { get; set; }
        public string? ProcGroupName { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public long? DeleteSessionId { get; set; }
        public DateTime? DeleteDate { get; set; }
    }
}
