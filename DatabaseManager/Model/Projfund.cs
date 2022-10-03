using System;
using System.Collections.Generic;

namespace DatabaseManager.Model
{
    public partial class Projfund
    {
        public long ProjFundId { get; set; }
        public long? FundId { get; set; }
        public long? ProjId { get; set; }
        public double? FundCost { get; set; }
        public double? FundWt { get; set; }
        public byte[]? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public byte[]? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public long? DeleteSessionId { get; set; }
        public byte[]? DeleteDate { get; set; }
    }
}
