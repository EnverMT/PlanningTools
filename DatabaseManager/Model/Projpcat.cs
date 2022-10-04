namespace DatabaseManager.Model
{
    public partial class Projpcat
    {
        public long ProjId { get; set; }
        public long ProjCatgTypeId { get; set; }
        public long? ProjCatgId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public long? DeleteSessionId { get; set; }
        public DateTime? DeleteDate { get; set; }
    }
}
