using System;
using System.Collections.Generic;

namespace DatabaseManager.Model
{
    public partial class Sumtask
    {
        public long? WbsId { get; set; }
        public long? ProjId { get; set; }
        public long? CompleteCnt { get; set; }
        public long? ActiveCnt { get; set; }
        public long? NotstartedCnt { get; set; }
        public long? BaseCompleteCnt { get; set; }
        public long? BaseActiveCnt { get; set; }
        public long? BaseNotstartedCnt { get; set; }
        public double? ActDrtnHrCnt { get; set; }
        public double? ActEquipQty { get; set; }
        public double? ActWorkQty { get; set; }
        public double? TotalDrtnHrCnt { get; set; }
        public double? BaseDrtnHrCnt { get; set; }
        public double? BaseWorkQty { get; set; }
        public double? BaseEquipQty { get; set; }
        public double? EtcWorkQty { get; set; }
        public double? RemainDrtnHrCnt { get; set; }
        public double? RemainWorkQty { get; set; }
        public double? RemainEquipQty { get; set; }
        public double? TotalFloatHrCnt { get; set; }
        public double? ActExpenseCost { get; set; }
        public double? ActWorkCost { get; set; }
        public double? ActEquipCost { get; set; }
        public double? BaseExpenseCost { get; set; }
        public double? BaseWorkCost { get; set; }
        public double? BaseEquipCost { get; set; }
        public double? Bcwp { get; set; }
        public double? Etc { get; set; }
        public double? Bcws { get; set; }
        public double? RemainExpenseCost { get; set; }
        public double? RemainWorkCost { get; set; }
        public double? RemainEquipCost { get; set; }
        public double? PerfmWorkQty { get; set; }
        public double? SchedWorkQty { get; set; }
        public byte[]? ActEndDate { get; set; }
        public byte[]? ActStartDate { get; set; }
        public byte[]? BaseEndDate { get; set; }
        public byte[]? BaseStartDate { get; set; }
        public byte[]? ReendDate { get; set; }
        public byte[]? RestartDate { get; set; }
        public double? ActThisPerWorkCost { get; set; }
        public double? ActThisPerWorkQty { get; set; }
        public double? ActThisPerEquipCost { get; set; }
        public double? ActThisPerEquipQty { get; set; }
        public double? BaseMatCost { get; set; }
        public double? RemainMatCost { get; set; }
        public double? ActMatCost { get; set; }
        public double? ActThisPerMatCost { get; set; }
        public double? EacWorkQty { get; set; }
        public byte[]? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public byte[]? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public long? DeleteSessionId { get; set; }
        public byte[]? DeleteDate { get; set; }
    }
}
