namespace DatabaseManager.Model
{
    public partial class Findate
    {
        public long FinDatesId { get; set; }
        public string? FinDatesName { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public long? DeleteSessionId { get; set; }
        public DateTime? DeleteDate { get; set; }
        public byte[]? FintmplId { get; set; }

        public virtual Fintmpl? Fintmpl { get; set; }
    }
}
