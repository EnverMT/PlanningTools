namespace DatabaseManager.Model
{
    public partial class Projthr
    {
        public long ThreshId { get; set; }
        public long? ProjId { get; set; }
        public long? ObsId { get; set; }
        public long? ThreshParmId { get; set; }
        public string? StatusCode { get; set; }
        public string? PriorityType { get; set; }
        public string? ThreshType { get; set; }
        public long? WbsId { get; set; }
        public long? TrackViewId { get; set; }
        public double? LoParmValue { get; set; }
        public double? HiParmValue { get; set; }
        public string? WindowStart { get; set; }
        public string? WindowEnd { get; set; }
        public byte[]? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public byte[]? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public long? DeleteSessionId { get; set; }
        public byte[]? DeleteDate { get; set; }
    }
}
