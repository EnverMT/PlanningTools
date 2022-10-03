using System;
using System.Collections.Generic;

namespace DatabaseManager.Model
{
    public partial class Taskfin
    {
        public long FinDatesId { get; set; }
        public long TaskId { get; set; }
        public long? ProjId { get; set; }
        public double? ActWorkQty { get; set; }
        public double? ActWorkCost { get; set; }
        public double? ActEquipQty { get; set; }
        public double? ActEquipCost { get; set; }
        public double? ActMatCost { get; set; }
        public double? ActExpenseCost { get; set; }
        public double? Bcwp { get; set; }
        public double? PerfmWorkQty { get; set; }
        public double? Bcws { get; set; }
        public double? SchedWorkQty { get; set; }
        public byte[]? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public byte[]? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public long? DeleteSessionId { get; set; }
        public byte[]? DeleteDate { get; set; }
    }
}
