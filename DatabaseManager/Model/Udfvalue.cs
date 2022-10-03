namespace DatabaseManager.Model
{
    public partial class Udfvalue
    {
        public long UdfTypeId { get; set; }
        public long FkId { get; set; }
        public long? ProjId { get; set; }
        public byte[]? UdfDate { get; set; }
        public double? UdfNumber { get; set; }
        public string? UdfText { get; set; }
        public long? UdfCodeId { get; set; }
        public byte[]? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public byte[]? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public long? DeleteSessionId { get; set; }
        public byte[]? DeleteDate { get; set; }
        public string? TableName { get; set; }
    }
}
