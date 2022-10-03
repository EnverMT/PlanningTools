namespace DatabaseManager.Model
{
    public partial class Umeasure
    {
        public long UnitId { get; set; }
        public long? SeqNum { get; set; }
        public string? UnitAbbrev { get; set; }
        public string? UnitName { get; set; }
        public byte[]? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public byte[]? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public long? DeleteSessionId { get; set; }
        public byte[]? DeleteDate { get; set; }
    }
}
