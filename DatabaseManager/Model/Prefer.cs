using System;
using System.Collections.Generic;

namespace DatabaseManager.Model
{
    public partial class Prefer
    {
        public long PreferId { get; set; }
        public long? MaxWbsLevelCnt { get; set; }
        public long? MaxRsrcLevelCnt { get; set; }
        public long? MaxAcctLevelCnt { get; set; }
        public long? MaxTaskActvTypeCnt { get; set; }
        public long? MaxObsLevelCnt { get; set; }
        public long? WeekStartDayNum { get; set; }
        public long? TaskCodeLen { get; set; }
        public long? ProjShortLen { get; set; }
        public long? WbsShortLen { get; set; }
        public long? RsrcShortLen { get; set; }
        public long? AcctShortLen { get; set; }
        public long? RoleShortLen { get; set; }
        public long? MaxBaseCnt { get; set; }
        public double? DefTargetDrtnHrCnt { get; set; }
        public double? DayHrCnt { get; set; }
        public double? WeekHrCnt { get; set; }
        public double? YearHrCnt { get; set; }
        public double? MonthHrCnt { get; set; }
        public long? MaxActvLevelCnt { get; set; }
        public long? MaxEpsLevelCnt { get; set; }
        public long? MaxPcatLevelCnt { get; set; }
        public long? MaxRcatLevelCnt { get; set; }
        public string? EvFixCostFlag { get; set; }
        public string? NameSepChar { get; set; }
        public string? YearChar { get; set; }
        public string? MonthChar { get; set; }
        public string? WeekChar { get; set; }
        public string? DayChar { get; set; }
        public string? HourChar { get; set; }
        public string? MinuteChar { get; set; }
        public string? DbName { get; set; }
        public string? TasksumPeriodType { get; set; }
        public string? TrsrcsumPeriodType { get; set; }
        public string? DatabaseVersion { get; set; }
        public string? PhaseLabel { get; set; }
        public long? CurrId { get; set; }
        public long? EvUserPct { get; set; }
        public double? EvEtcUserValue { get; set; }
        public string? EvComputeType { get; set; }
        public string? EvEtcComputeType { get; set; }
        public string? RptHeader1 { get; set; }
        public string? RptHeader2 { get; set; }
        public string? RptHeader3 { get; set; }
        public string? RptFooter1 { get; set; }
        public string? RptFooter2 { get; set; }
        public string? RptFooter3 { get; set; }
        public string? RptUser1 { get; set; }
        public string? RptUser2 { get; set; }
        public string? RptUser3 { get; set; }
        public string? LicenseData { get; set; }
        public long? MaxRoleLevelCnt { get; set; }
        public string? ExpRootUrl { get; set; }
        public string? AllowUserTimePeriodFlag { get; set; }
        public byte[]? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public byte[]? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public long? DeleteSessionId { get; set; }
        public byte[]? DeleteDate { get; set; }
    }
}
