namespace DatabaseManager.Model
{
    public partial class Rolecattype
    {
        public long RoleCatgTypeId { get; set; }
        public long? SeqNum { get; set; }
        public long? RoleCatgShortLen { get; set; }
        public string? RoleCatgType { get; set; }
        public string? SuperFlag { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public long? DeleteSessionId { get; set; }
        public DateTime? DeleteDate { get; set; }
    }
}
