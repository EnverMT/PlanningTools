namespace DatabaseManager.Model
{
    public partial class Account
    {
        public long AcctId { get; set; }
        public long? ParentAcctId { get; set; }
        public long? AcctSeqNum { get; set; }
        public string? AcctName { get; set; }
        public string? AcctShortName { get; set; }
        public byte[]? AcctDescr { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public long? DeleteSessionId { get; set; }
        public DateTime? DeleteDate { get; set; }
    }
}
