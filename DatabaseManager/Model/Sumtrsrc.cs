namespace DatabaseManager.Model
{
    public partial class Sumtrsrc
    {
        public long? SumtrsrcId { get; set; }
        public long? ProjId { get; set; }
        public long? WbsId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? SpreadType { get; set; }
        public long? RsrcId { get; set; }
        public long? RoleId { get; set; }
        public double? StaffedActQty { get; set; }
        public double? UnstaffedActQty { get; set; }
        public double? ActQty { get; set; }
        public double? StaffedActCost { get; set; }
        public double? UnstaffedActCost { get; set; }
        public double? ActCost { get; set; }
        public double? StaffedActOtQty { get; set; }
        public double? UnstaffedActOtQty { get; set; }
        public double? ActOtQty { get; set; }
        public double? StaffedActOtCost { get; set; }
        public double? UnstaffedActOtCost { get; set; }
        public double? ActOtCost { get; set; }
        public double? StaffedActRegCost { get; set; }
        public double? UnstaffedActRegCost { get; set; }
        public double? ActRegCost { get; set; }
        public double? StaffedActRegQty { get; set; }
        public double? UnstaffedActRegQty { get; set; }
        public double? ActRegQty { get; set; }
        public double? StaffedLateRemainQty { get; set; }
        public double? UnstaffedLateRemainQty { get; set; }
        public double? LateRemainQty { get; set; }
        public double? StaffedLateRemainCost { get; set; }
        public double? UnstaffedLateRemainCost { get; set; }
        public double? LateRemainCost { get; set; }
        public double? StaffedRemainQty { get; set; }
        public double? UnstaffedRemainQty { get; set; }
        public double? RemainQty { get; set; }
        public double? StaffedRemainCost { get; set; }
        public double? UnstaffedRemainCost { get; set; }
        public double? RemainCost { get; set; }
        public double? StaffedTargetQty { get; set; }
        public double? UnstaffedTargetQty { get; set; }
        public double? TargetQty { get; set; }
        public double? StaffedTargetCost { get; set; }
        public double? UnstaffedTargetCost { get; set; }
        public double? TargetCost { get; set; }
        public double? StaffedTotalQty { get; set; }
        public double? UnstaffedTotalQty { get; set; }
        public double? TotalQty { get; set; }
        public double? StaffedTotalCost { get; set; }
        public double? UnstaffedTotalCost { get; set; }
        public double? TotalCost { get; set; }
        public double? FinPeriodActQty { get; set; }
        public double? FinPeriodActCost { get; set; }
        public double? FinPeriodTotalQty { get; set; }
        public double? FinPeriodTotalCost { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public long? DeleteSessionId { get; set; }
        public DateTime? DeleteDate { get; set; }
    }
}
