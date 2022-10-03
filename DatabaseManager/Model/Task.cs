﻿namespace DatabaseManager.Model
{
    public partial class Task
    {
        public long TaskId { get; set; }
        public long? ProjId { get; set; }
        public long? WbsId { get; set; }
        public long? ClndrId { get; set; }
        public double? PhysCompletePct { get; set; }
        public string? RevFdbkFlag { get; set; }
        public string? LockPlanFlag { get; set; }
        public string? AutoComputeActFlag { get; set; }
        public string? CompletePctType { get; set; }
        public string? TaskType { get; set; }
        public string? DurationType { get; set; }
        public string? StatusCode { get; set; }
        public string? TaskCode { get; set; }
        public string? TaskName { get; set; }
        public long? RsrcId { get; set; }
        public double? TotalFloatHrCnt { get; set; }
        public double? FreeFloatHrCnt { get; set; }
        public double? RemainDrtnHrCnt { get; set; }
        public double? ActWorkQty { get; set; }
        public double? RemainWorkQty { get; set; }
        public double? TargetWorkQty { get; set; }
        public double? TargetDrtnHrCnt { get; set; }
        public double? TargetEquipQty { get; set; }
        public double? ActEquipQty { get; set; }
        public double? RemainEquipQty { get; set; }
        public byte[]? CstrDate { get; set; }
        public byte[]? ActStartDate { get; set; }
        public byte[]? ActEndDate { get; set; }
        public byte[]? LateStartDate { get; set; }
        public byte[]? LateEndDate { get; set; }
        public byte[]? ExpectEndDate { get; set; }
        public byte[]? EarlyStartDate { get; set; }
        public byte[]? EarlyEndDate { get; set; }
        public byte[]? RestartDate { get; set; }
        public byte[]? ReendDate { get; set; }
        public byte[]? TargetStartDate { get; set; }
        public byte[]? TargetEndDate { get; set; }
        public byte[]? RemLateStartDate { get; set; }
        public byte[]? RemLateEndDate { get; set; }
        public string? CstrType { get; set; }
        public string? PriorityType { get; set; }
        public byte[]? SuspendDate { get; set; }
        public byte[]? ResumeDate { get; set; }
        public long? FloatPath { get; set; }
        public long? FloatPathOrder { get; set; }
        public string? Guid { get; set; }
        public string? TmplGuid { get; set; }
        public byte[]? CstrDate2 { get; set; }
        public string? CstrType2 { get; set; }
        public string? DrivingPathFlag { get; set; }
        public double? ActThisPerWorkQty { get; set; }
        public double? ActThisPerEquipQty { get; set; }
        public byte[]? ExternalEarlyStartDate { get; set; }
        public byte[]? ExternalLateEndDate { get; set; }
        public long? LocationId { get; set; }
        public double? EstWt { get; set; }
        public byte[]? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public byte[]? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public long? DeleteSessionId { get; set; }
        public byte[]? DeleteDate { get; set; }
        public double? ScpPctComplete { get; set; }
        public string? ControlUpdatesFlag { get; set; }
    }
}