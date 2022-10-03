namespace DatabaseManager.Model
{
    public partial class Projpcat
    {
        public long ProjId { get; set; }
        public long ProjCatgTypeId { get; set; }
        public long? ProjCatgId { get; set; }
        public byte[]? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public byte[]? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public long? DeleteSessionId { get; set; }
        public byte[]? DeleteDate { get; set; }
    }
}
