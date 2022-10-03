using System;
using System.Collections.Generic;

namespace DatabaseManager.Model
{
    public partial class Projissu
    {
        public long IssueId { get; set; }
        public long? ObsId { get; set; }
        public long? ProjId { get; set; }
        public long? RsrcId { get; set; }
        public long? TaskId { get; set; }
        public long? ThreshId { get; set; }
        public long? ThreshParmId { get; set; }
        public long? TrackViewId { get; set; }
        public long? WbsId { get; set; }
        public string? AddByName { get; set; }
        public string? IssueName { get; set; }
        public byte[]? ResolvDate { get; set; }
        public byte[]? AddDate { get; set; }
        public string? PriorityType { get; set; }
        public string? StatusCode { get; set; }
        public long? BaseProjId { get; set; }
        public double? HiParmValue { get; set; }
        public double? IssueValue { get; set; }
        public double? LoParmValue { get; set; }
        public byte[]? IssueNotes { get; set; }
        public long? WorkspaceId { get; set; }
        public byte[]? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public byte[]? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public long? DeleteSessionId { get; set; }
        public byte[]? DeleteDate { get; set; }
    }
}
