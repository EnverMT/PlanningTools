namespace DatabaseManager.Model
{
    public partial class Userset
    {
        public string Namespace { get; set; } = null!;
        public string SettingName { get; set; } = null!;
        public string? SettingValue { get; set; }
        public long UserId { get; set; }
        public byte[]? UsersetBlob { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public long? DeleteSessionId { get; set; }
        public DateTime? DeleteDate { get; set; }
    }
}
