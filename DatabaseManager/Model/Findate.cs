namespace DatabaseManager.Model
{
    public partial class Findate
    {
        public long FinDatesId { get; set; }
        public string? FinDatesName { get; set; }
        public byte[]? StartDate { get; set; }
        public byte[]? EndDate { get; set; }
        public byte[]? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public byte[]? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public long? DeleteSessionId { get; set; }
        public byte[]? DeleteDate { get; set; }
        public byte[]? FintmplId { get; set; }

        public virtual Fintmpl? Fintmpl { get; set; }
    }
}
