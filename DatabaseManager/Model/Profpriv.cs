namespace DatabaseManager.Model
{
    public partial class Profpriv
    {
        public long ProfId { get; set; }
        public long PrivNum { get; set; }
        public string? AllowFlag { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public long? DeleteSessionId { get; set; }
        public DateTime? DeleteDate { get; set; }
    }
}
