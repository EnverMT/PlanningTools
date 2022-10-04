namespace DatabaseManager.Model
{
    public partial class Rsrcrcat
    {
        public long RsrcId { get; set; }
        public long RsrcCatgTypeId { get; set; }
        public long? RsrcCatgId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public long? DeleteSessionId { get; set; }
        public DateTime? DeleteDate { get; set; }
    }
}
