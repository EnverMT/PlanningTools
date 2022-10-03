namespace DatabaseManager.Model
{
    public partial class Role
    {
        public long RoleId { get; set; }
        public long? ParentRoleId { get; set; }
        public long? SeqNum { get; set; }
        public string? RoleName { get; set; }
        public string? RoleShortName { get; set; }
        public long? PobsId { get; set; }
        public string? DefCostQtyLinkFlag { get; set; }
        public string? CostQtyType { get; set; }
        public byte[]? RoleDescr { get; set; }
        public byte[]? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public byte[]? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public long? DeleteSessionId { get; set; }
        public byte[]? DeleteDate { get; set; }
    }
}
