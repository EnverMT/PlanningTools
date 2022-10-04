namespace DatabaseManager.Model
{
    public partial class Phase
    {
        public long PhaseId { get; set; }
        public long? SeqNum { get; set; }
        public string? PhaseName { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public long? DeleteSessionId { get; set; }
        public DateTime? DeleteDate { get; set; }
    }
}
