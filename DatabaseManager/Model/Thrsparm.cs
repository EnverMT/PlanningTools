namespace DatabaseManager.Model
{
    public partial class Thrsparm
    {
        public long ThreshParmId { get; set; }
        public long? SeqNum { get; set; }
        public string? WbsFlag { get; set; }
        public string? TaskFlag { get; set; }
        public string? RsrcFlag { get; set; }
        public string? ThreshParmType { get; set; }
        public string? ThreshParmName { get; set; }
        public string? ThreshFieldName { get; set; }
        public string? ThreshShortName { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public long? DeleteSessionId { get; set; }
        public DateTime? DeleteDate { get; set; }
    }
}
