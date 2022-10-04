namespace DatabaseManager.Model
{
    public partial class Pob
    {
        public long PobsId { get; set; }
        public long? PobsParentId { get; set; }
        public long? SeqNum { get; set; }
        public string? PobsName { get; set; }
        public string? PobsDescr { get; set; }
        public string? PobsManager { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public long? DeleteSessionId { get; set; }
        public DateTime? DeleteDate { get; set; }
    }
}
