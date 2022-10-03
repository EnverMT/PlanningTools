namespace DatabaseManager.Model
{
    public partial class User
    {
        public long UserId { get; set; }
        public string? GlobalFlag { get; set; }
        public string? EmailType { get; set; }
        public string? UserName { get; set; }
        public long? ProfId { get; set; }
        public long? CurrId { get; set; }
        public string? Guid { get; set; }
        public string? EmailSrvUserName { get; set; }
        public string? OfficePhone { get; set; }
        public string? ActualName { get; set; }
        public string? EmailSendServer { get; set; }
        public string? EmailAddr { get; set; }
        public string? EmailSrvPasswd { get; set; }
        public string? Passwd { get; set; }
        public string? AllRsrcAccessFlag { get; set; }
        public string? CrExternalKey { get; set; }
        public byte[]? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public byte[]? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public long? DeleteSessionId { get; set; }
        public byte[]? DeleteDate { get; set; }
    }
}
