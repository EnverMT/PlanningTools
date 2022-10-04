namespace DatabaseManager.Model
{
    public partial class Costtype
    {
        public long CostTypeId { get; set; }
        public long? SeqNum { get; set; }
        public string? CostType1 { get; set; }//CostType"1"
        public DateTime? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public long? DeleteSessionId { get; set; }
        public DateTime? DeleteDate { get; set; }
    }
}
