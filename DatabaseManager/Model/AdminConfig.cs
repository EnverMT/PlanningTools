namespace DatabaseManager.Model
{
    public partial class AdminConfig
    {
        public string ConfigName { get; set; } = null!;
        public string? ConfigType { get; set; }
        public string? FactoryVersion { get; set; }
        public DateTime? LastChangeDate { get; set; }
        public string? ConfigValue { get; set; }
        public byte[]? ConfigData { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public long? DeleteSessionId { get; set; }
        public DateTime? DeleteDate { get; set; }
    }
}
