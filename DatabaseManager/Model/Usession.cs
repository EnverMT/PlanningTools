namespace DatabaseManager.Model
{
    public partial class Usession
    {
        public long SessionId { get; set; }
        public byte[]? LoginTime { get; set; }
        public byte[]? LastActiveTime { get; set; }
        public string? HostName { get; set; }
        public long? UserId { get; set; }
        public long? ProcessNum { get; set; }
        public string? AppName { get; set; }
        public string? HardDriveCode { get; set; }
        public string? DbEngineType { get; set; }
        public string? OsUserName { get; set; }
        public string? VdbInstanceGuid { get; set; }
        public long? Spid { get; set; }
        public byte[]? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public byte[]? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public long? DeleteSessionId { get; set; }
        public byte[]? DeleteDate { get; set; }
    }
}
