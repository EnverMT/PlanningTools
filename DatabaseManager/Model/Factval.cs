namespace DatabaseManager.Model
{
    public partial class Factval
    {
        public long FactValId { get; set; }
        public long? FactId { get; set; }
        public string? FactValue { get; set; }
        public string? FactValueDescr { get; set; }
        public byte[]? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public byte[]? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public long? DeleteSessionId { get; set; }
        public byte[]? DeleteDate { get; set; }
    }
}
