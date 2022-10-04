using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseManager.Model
{
    public partial class Task
    {
        public long TaskId { get; set; }
        public long ProjId { get; set; }
        public Project Project { get; set; }
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
        public DateTime? CstrDate { get; set; }
        public DateTime? ActStartDate { get; set; }
        public DateTime? ActEndDate { get; set; }
        public DateTime? LateStartDate { get; set; }
        public DateTime? LateEndDate { get; set; }
        public DateTime? ExpectEndDate { get; set; }
        public DateTime? EarlyStartDate { get; set; }
        public DateTime? EarlyEndDate { get; set; }
        public DateTime? RestartDate { get; set; }
        public DateTime? ReendDate { get; set; }
        public DateTime? TargetStartDate { get; set; }
        public DateTime? TargetEndDate { get; set; }
        public DateTime? RemLateStartDate { get; set; }
        public DateTime? RemLateEndDate { get; set; }
        public string? CstrType { get; set; }
        public string? PriorityType { get; set; }
        public DateTime? SuspendDate { get; set; }
        public DateTime? ResumeDate { get; set; }
        public long? FloatPath { get; set; }
        public long? FloatPathOrder { get; set; }
        public string? Guid { get; set; }
        public string? TmplGuid { get; set; }
        public DateTime? CstrDate2 { get; set; }
        public string? CstrType2 { get; set; }
        public string? DrivingPathFlag { get; set; }
        public double? ActThisPerWorkQty { get; set; }
        public double? ActThisPerEquipQty { get; set; }
        public DateTime? ExternalEarlyStartDate { get; set; }
        public DateTime? ExternalLateEndDate { get; set; }
        public long? LocationId { get; set; }
        public double? EstWt { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public long? DeleteSessionId { get; set; }
        public DateTime? DeleteDate { get; set; }
        public double? ScpPctComplete { get; set; }
        public string? ControlUpdatesFlag { get; set; }
    }
}
