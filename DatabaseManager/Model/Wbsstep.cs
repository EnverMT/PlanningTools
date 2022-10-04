namespace DatabaseManager.Model
{
    public partial class Wbsstep
    {
        public long WbsStepId { get; set; }
        public long? ProjId { get; set; }
        public long? WbsId { get; set; }
        public long? SeqNum { get; set; }
        public string? CompleteFlag { get; set; }
        public string? StepName { get; set; }
        public double? StepWt { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public long? DeleteSessionId { get; set; }
        public DateTime? DeleteDate { get; set; }
    }
}
