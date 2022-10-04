namespace DatabaseManager.Model
{
    public partial class Udfvalue
    {
        public long UdfTypeId { get; set; }
        public long FkId { get; set; }
        public long? ProjId { get; set; }
        public DateTime? UdfDate { get; set; }
        public double? UdfNumber { get; set; }
        public string? UdfText { get; set; }
        public long? UdfCodeId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public long? DeleteSessionId { get; set; }
        public DateTime? DeleteDate { get; set; }
        public string? TableName { get; set; }
    }
}
