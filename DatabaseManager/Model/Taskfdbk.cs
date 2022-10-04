namespace DatabaseManager.Model
{
    public partial class Taskfdbk
    {
        public long TaskId { get; set; }
        public long? ProjId { get; set; }
        public byte[]? TaskFdbk1 { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public long? DeleteSessionId { get; set; }
        public DateTime? DeleteDate { get; set; }
    }
}
