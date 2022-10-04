namespace DatabaseManager.Model
{
    public partial class Rfolio
    {
        public long RfolioId { get; set; }
        public long? UserId { get; set; }
        public string? RfolioType { get; set; }
        public string? RfolioName { get; set; }
        public string? RfolioDescr { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public long? DeleteSessionId { get; set; }
        public DateTime? DeleteDate { get; set; }
    }
}
