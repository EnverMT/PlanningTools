﻿namespace DatabaseManager.Model
{
    public partial class Risktype
    {
        public long RiskTypeId { get; set; }
        public long? SeqNum { get; set; }
        public string? RiskType1 { get; set; }
        public long? ParentRiskTypeId { get; set; }
        public byte[]? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public byte[]? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public long? DeleteSessionId { get; set; }
        public byte[]? DeleteDate { get; set; }
    }
}