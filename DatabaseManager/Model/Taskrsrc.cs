namespace DatabaseManager.Model
{
    public partial class Taskrsrc
    {
        public long TaskrsrcId { get; set; }
        public long? TaskId { get; set; }
        public long? ProjId { get; set; }
        public string? CostQtyLinkFlag { get; set; }
        public long? RoleId { get; set; }
        public long? AcctId { get; set; }
        public long? RsrcId { get; set; }
        public long? PobsId { get; set; }
        public long? SkillLevel { get; set; }
        public double? RemainQty { get; set; }
        public double? TargetQty { get; set; }
        public double? RemainQtyPerHr { get; set; }
        public double? TargetLagDrtnHrCnt { get; set; }
        public double? TargetQtyPerHr { get; set; }
        public double? ActOtQty { get; set; }
        public double? ActRegQty { get; set; }
        public double? RelagDrtnHrCnt { get; set; }
        public double? OtFactor { get; set; }
        public double? CostPerQty { get; set; }
        public double? TargetCost { get; set; }
        public double? ActRegCost { get; set; }
        public double? ActOtCost { get; set; }
        public double? RemainCost { get; set; }
        public DateTime? ActStartDate { get; set; }
        public DateTime? ActEndDate { get; set; }
        public DateTime? RestartDate { get; set; }
        public DateTime? ReendDate { get; set; }
        public DateTime? TargetStartDate { get; set; }
        public DateTime? TargetEndDate { get; set; }
        public DateTime? RemLateStartDate { get; set; }
        public DateTime? RemLateEndDate { get; set; }
        public string? RollupDatesFlag { get; set; }
        public string? TargetCrv { get; set; }
        public string? RemainCrv { get; set; }
        public string? ActualCrv { get; set; }
        public string? TsPendActEndFlag { get; set; }
        public string? Guid { get; set; }
        public string? RateType { get; set; }
        public double? ActThisPerCost { get; set; }
        public double? ActThisPerQty { get; set; }
        public long? CurvId { get; set; }
        public string? RsrcType { get; set; }
        public string? CostPerQtySourceType { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public long? DeleteSessionId { get; set; }
        public DateTime? DeleteDate { get; set; }
    }
}
