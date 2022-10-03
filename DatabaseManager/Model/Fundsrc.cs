namespace DatabaseManager.Model
{
    public partial class Fundsrc
    {
        public long FundId { get; set; }
        public long? ParentFundId { get; set; }
        public long? SeqNum { get; set; }
        public string? FundName { get; set; }
        public byte[]? FundDescr { get; set; }
        public byte[]? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public byte[]? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public long? DeleteSessionId { get; set; }
        public byte[]? DeleteDate { get; set; }
    }
}
