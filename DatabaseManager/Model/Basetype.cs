namespace DatabaseManager.Model
{
    public partial class Basetype
    {
        public long BaseTypeId { get; set; }
        public long? BaseTypeSeqNum { get; set; }
        public string? BaseType1 { get; set; }// BaseType"1"?
        public DateTime? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public long? DeleteSessionId { get; set; }
        public DateTime? DeleteDate { get; set; }
    }
}
