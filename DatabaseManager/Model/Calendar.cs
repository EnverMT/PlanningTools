using System;
using System.Collections.Generic;

namespace DatabaseManager.Model
{
    public partial class Calendar
    {
        public long ClndrId { get; set; }
        public string? DefaultFlag { get; set; }
        public string? ClndrName { get; set; }
        public long? ProjId { get; set; }
        public long? BaseClndrId { get; set; }
        public byte[]? LastChngDate { get; set; }
        public string? ClndrType { get; set; }
        public double? DayHrCnt { get; set; }
        public double? WeekHrCnt { get; set; }
        public double? MonthHrCnt { get; set; }
        public double? YearHrCnt { get; set; }
        public string? RsrcPrivate { get; set; }
        public byte[]? ClndrData { get; set; }
        public byte[]? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public byte[]? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public long? DeleteSessionId { get; set; }
        public byte[]? DeleteDate { get; set; }
    }
}
