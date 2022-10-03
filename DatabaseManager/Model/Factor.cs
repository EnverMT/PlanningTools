namespace DatabaseManager.Model
{
    public partial class Factor
    {
        public long FactId { get; set; }
        public long? FactSeqNum { get; set; }
        public string? FactName { get; set; }
        public string? FactType { get; set; }
        public long? DefFactValId { get; set; }
        public byte[]? FactDescr { get; set; }
        public byte[]? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public byte[]? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public long? DeleteSessionId { get; set; }
        public byte[]? DeleteDate { get; set; }
    }
}
