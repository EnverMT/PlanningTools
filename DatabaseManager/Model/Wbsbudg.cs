using System;
using System.Collections.Generic;

namespace DatabaseManager.Model
{
    public partial class Wbsbudg
    {
        public long WbsBudgId { get; set; }
        public long? ProjId { get; set; }
        public long? WbsId { get; set; }
        public byte[]? StartDate { get; set; }
        public double? SpendCost { get; set; }
        public double? BenefitCost { get; set; }
        public byte[]? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public byte[]? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public long? DeleteSessionId { get; set; }
        public byte[]? DeleteDate { get; set; }
    }
}
