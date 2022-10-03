using System;
using System.Collections.Generic;

namespace DatabaseManager.Model
{
    public partial class Project
    {
        public long ProjId { get; set; }
        public long? FyStartMonthNum { get; set; }
        public string? RsrcSelfAddFlag { get; set; }
        public string? AllowCompleteFlag { get; set; }
        public string? RsrcMultiAssignFlag { get; set; }
        public string? CheckoutFlag { get; set; }
        public string? ProjectFlag { get; set; }
        public string? StepCompleteFlag { get; set; }
        public string? CostQtyRecalcFlag { get; set; }
        public string? BatchSumFlag { get; set; }
        public string? NameSepChar { get; set; }
        public string? DefCompletePctType { get; set; }
        public string? ProjShortName { get; set; }
        public long? AcctId { get; set; }
        public long? OrigProjId { get; set; }
        public long? SourceProjId { get; set; }
        public long? BaseTypeId { get; set; }
        public long? ClndrId { get; set; }
        public long? SumBaseProjId { get; set; }
        public long? TaskCodeBase { get; set; }
        public long? TaskCodeStep { get; set; }
        public long? PriorityNum { get; set; }
        public long? WbsMaxSumLevel { get; set; }
        public long? StrgyPriorityNum { get; set; }
        public long? LastChecksum { get; set; }
        public double? CriticalDrtnHrCnt { get; set; }
        public double? DefCostPerQty { get; set; }
        public byte[]? LastRecalcDate { get; set; }
        public byte[]? PlanStartDate { get; set; }
        public byte[]? PlanEndDate { get; set; }
        public byte[]? ScdEndDate { get; set; }
        public byte[]? AddDate { get; set; }
        public byte[]? LastTasksumDate { get; set; }
        public byte[]? FcstStartDate { get; set; }
        public string? DefDurationType { get; set; }
        public string? TaskCodePrefix { get; set; }
        public string? Guid { get; set; }
        public string? DefQtyType { get; set; }
        public string? AddByName { get; set; }
        public string? WebLocalRootPath { get; set; }
        public string? ProjUrl { get; set; }
        public string? DefRateType { get; set; }
        public string? AddActRemainFlag { get; set; }
        public string? ActThisPerLinkFlag { get; set; }
        public string? DefTaskType { get; set; }
        public string? ActPctLinkFlag { get; set; }
        public string? CriticalPathType { get; set; }
        public string? TaskCodePrefixFlag { get; set; }
        public string? DefRollupDatesFlag { get; set; }
        public string? UseProjectBaselineFlag { get; set; }
        public string? RemTargetLinkFlag { get; set; }
        public string? ResetPlannedFlag { get; set; }
        public string? AllowNegActFlag { get; set; }
        public byte[]? CheckoutDate { get; set; }
        public long? CheckoutUserId { get; set; }
        public string? SumAssignLevel { get; set; }
        public long? LastFinDatesId { get; set; }
        public byte[]? LastBaselineUpdateDate { get; set; }
        public string? CrExternalKey { get; set; }
        public byte[]? ApplyActualsDate { get; set; }
        public long? LocationId { get; set; }
        public byte[]? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public byte[]? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public long? DeleteSessionId { get; set; }
        public byte[]? DeleteDate { get; set; }
        public string? ControlUpdatesFlag { get; set; }
        public byte[]? FintmplId { get; set; }

        public virtual Fintmpl? Fintmpl { get; set; }
    }
}
