namespace DatabaseManager.Model
{
    public partial class Projrisk
    {
        public long RiskId { get; set; }
        public string? RiskCode { get; set; }
        public long? ProjId { get; set; }
        public byte[]? AddDate { get; set; }
        public string? StatusCode { get; set; }
        public string? RiskName { get; set; }
        public long? RiskTypeId { get; set; }
        public long? RsrcId { get; set; }
        public string? RiskDesc { get; set; }
        public string? RiskToType { get; set; }
        public long? IdentifiedById { get; set; }
        public string? ResponseType { get; set; }
        public string? ResponseText { get; set; }
        public string? PreRspPrblty { get; set; }
        public string? PreRspSchdPrblty { get; set; }
        public string? PreRspCostPrblty { get; set; }
        public string? PostRspPrblty { get; set; }
        public string? PostRspSchdPrblty { get; set; }
        public string? PostRspCostPrblty { get; set; }
        public string? RiskCause { get; set; }
        public string? RiskEffect { get; set; }
        public string? Notes { get; set; }
        public byte[]? RiskDescr { get; set; }
        public byte[]? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public byte[]? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public long? DeleteSessionId { get; set; }
        public byte[]? DeleteDate { get; set; }
    }
}
