namespace DatabaseManager.Model
{
    public partial class Projwb
    {
        public long WbsId { get; set; }
        public long? ProjId { get; set; }
        public long? ObsId { get; set; }
        public long? SeqNum { get; set; }
        public string? ProjNodeFlag { get; set; }
        public string? SumDataFlag { get; set; }
        public string? StatusCode { get; set; }
        public string? WbsShortName { get; set; }
        public string? WbsName { get; set; }
        public long? PhaseId { get; set; }
        public long? ParentWbsId { get; set; }
        public long? EvUserPct { get; set; }
        public double? EvEtcUserValue { get; set; }
        public double? OrigCost { get; set; }
        public double? IndepRemainTotalCost { get; set; }
        public double? AnnDscntRatePct { get; set; }
        public string? DscntPeriodType { get; set; }
        public double? IndepRemainWorkQty { get; set; }
        public DateTime? AnticipStartDate { get; set; }
        public DateTime? AnticipEndDate { get; set; }
        public string? EvComputeType { get; set; }
        public string? EvEtcComputeType { get; set; }
        public string? Guid { get; set; }
        public string? TmplGuid { get; set; }
        public double? EstWt { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public long? DeleteSessionId { get; set; }
        public DateTime? DeleteDate { get; set; }
    }
}
