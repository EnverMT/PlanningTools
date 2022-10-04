namespace DatabaseManager.Model
{
    public partial class Rsrccurv
    {
        public long CurvId { get; set; }
        public string? CurvName { get; set; }
        public string? DefaultFlag { get; set; }
        public byte[]? CurvData { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public long? DeleteSessionId { get; set; }
        public DateTime? DeleteDate { get; set; }
    }
}
