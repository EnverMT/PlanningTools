namespace DatabaseManager.Model
{
    public partial class Asgnmntcattype
    {
        public long AsgnmntCatgTypeId { get; set; }
        public long? SeqNum { get; set; }
        public long? AsgnmntCatgShortLen { get; set; }
        public string? AsgnmntCatgType { get; set; }
        public string? SuperFlag { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public long? DeleteSessionId { get; set; }
        public DateTime? DeleteDate { get; set; }
    }
}
