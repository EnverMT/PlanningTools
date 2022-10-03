namespace DatabaseManager.Model
{
    public partial class Trsrcfin
    {
        public long FinDatesId { get; set; }
        public long TaskrsrcId { get; set; }
        public long? TaskId { get; set; }
        public long? ProjId { get; set; }
        public double? ActQty { get; set; }
        public double? ActCost { get; set; }
        public byte[]? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public byte[]? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public long? DeleteSessionId { get; set; }
        public byte[]? DeleteDate { get; set; }
    }
}
