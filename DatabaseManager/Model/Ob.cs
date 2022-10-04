namespace DatabaseManager.Model
{
    public partial class Ob
    {
        public long ObsId { get; set; }
        public long? ParentObsId { get; set; }
        public string? Guid { get; set; }
        public long? SeqNum { get; set; }
        public string? ObsName { get; set; }
        public byte[]? ObsDescr { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public long? DeleteSessionId { get; set; }
        public DateTime? DeleteDate { get; set; }
    }
}
