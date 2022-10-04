namespace DatabaseManager.Model
{
    public partial class Usercol
    {
        public long UserColId { get; set; }
        public string? TableName { get; set; }
        public string? LogicalDataType { get; set; }
        public string? UserColName { get; set; }
        public string? UserColLabel { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public long? DeleteSessionId { get; set; }
        public DateTime? DeleteDate { get; set; }
    }
}
