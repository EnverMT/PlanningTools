namespace DatabaseManager.Model
{
    public partial class Shiftper
    {
        public long ShiftPeriodId { get; set; }
        public long? ShiftId { get; set; }
        public double? ShiftStartHrNum { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public long? DeleteSessionId { get; set; }
        public DateTime? DeleteDate { get; set; }
    }
}
