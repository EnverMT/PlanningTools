namespace DatabaseManager.Model
{
    public partial class Usereng
    {
        public long UserEngId { get; set; }
        public long? UserId { get; set; }
        public string? DbEngineType { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public long? DeleteSessionId { get; set; }
        public DateTime? DeleteDate { get; set; }
    }
}
