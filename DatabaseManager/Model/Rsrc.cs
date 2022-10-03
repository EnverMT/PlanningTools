namespace DatabaseManager.Model
{
    public partial class Rsrc
    {
        public long RsrcId { get; set; }
        public long? ParentRsrcId { get; set; }
        public long? ClndrId { get; set; }
        public long? RoleId { get; set; }
        public long? ShiftId { get; set; }
        public long? UserId { get; set; }
        public long? PobsId { get; set; }
        public string? Guid { get; set; }
        public long? RsrcSeqNum { get; set; }
        public string? EmailAddr { get; set; }
        public string? EmployeeCode { get; set; }
        public string? OfficePhone { get; set; }
        public string? OtherPhone { get; set; }
        public string? RsrcName { get; set; }
        public string? RsrcShortName { get; set; }
        public string? RsrcTitleName { get; set; }
        public double? DefQtyPerHr { get; set; }
        public string? CostQtyType { get; set; }
        public double? OtFactor { get; set; }
        public string? ActiveFlag { get; set; }
        public string? AutoComputeActFlag { get; set; }
        public string? DefCostQtyLinkFlag { get; set; }
        public string? OtFlag { get; set; }
        public long? CurrId { get; set; }
        public long? UnitId { get; set; }
        public string? RsrcType { get; set; }
        public long? LocationId { get; set; }
        public byte[]? RsrcNotes { get; set; }
        public byte[]? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public byte[]? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public long? DeleteSessionId { get; set; }
        public byte[]? DeleteDate { get; set; }
        public string? TimesheetFlag { get; set; }
    }
}
