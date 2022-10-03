namespace DatabaseManager.Model
{
    public partial class Filtprop
    {
        public long FilterId { get; set; }
        public long? UserId { get; set; }
        public string? FilterType { get; set; }
        public string? FilterName { get; set; }
        public string? TableName { get; set; }
        public long? RptId { get; set; }
        public byte[]? FilterData { get; set; }
        public byte[]? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public byte[]? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public long? DeleteSessionId { get; set; }
        public byte[]? DeleteDate { get; set; }
    }
}
