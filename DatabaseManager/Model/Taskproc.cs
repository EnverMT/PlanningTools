namespace DatabaseManager.Model
{
    public partial class Taskproc
    {
        public long ProcId { get; set; }
        public long? TaskId { get; set; }
        public long? ProjId { get; set; }
        public long? SeqNum { get; set; }
        public string? ProcName { get; set; }
        public string? CompleteFlag { get; set; }
        public double? ProcWt { get; set; }
        public double? CompletePct { get; set; }
        public byte[]? ProcDescr { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public long? DeleteSessionId { get; set; }
        public DateTime? DeleteDate { get; set; }
    }
}
