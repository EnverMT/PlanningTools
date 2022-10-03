using System;
using System.Collections.Generic;

namespace DatabaseManager.Model
{
    public partial class Currtype
    {
        public long CurrId { get; set; }
        public long? DecimalDigitCnt { get; set; }
        public string? CurrSymbol { get; set; }
        public string? DecimalSymbol { get; set; }
        public string? DigitGroupSymbol { get; set; }
        public string? PosCurrFmtType { get; set; }
        public string? NegCurrFmtType { get; set; }
        public string? CurrType1 { get; set; }
        public string? CurrShortName { get; set; }
        public long? GroupDigitCnt { get; set; }
        public double? BaseExchRate { get; set; }
        public byte[]? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public byte[]? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public long? DeleteSessionId { get; set; }
        public byte[]? DeleteDate { get; set; }
    }
}
