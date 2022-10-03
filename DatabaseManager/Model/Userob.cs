namespace DatabaseManager.Model
{
    public partial class Userob
    {
        public long UserId { get; set; }
        public long ObsId { get; set; }
        public long? ProfId { get; set; }
        public byte[]? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public byte[]? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public long? DeleteSessionId { get; set; }
        public byte[]? DeleteDate { get; set; }
    }
}
