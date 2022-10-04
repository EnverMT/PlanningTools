namespace DatabaseManager.Model
{
    public partial class Pkxref
    {
        public long? SystemId { get; set; }
        public string? ContextName { get; set; }
        public long? Pk1 { get; set; }
        public long? Pk2 { get; set; }
        public long? OldPk1 { get; set; }
        public long? OldPk2 { get; set; }
        public string? OldStr { get; set; }
        public string? NewStr { get; set; }
        public DateTime? AddDate { get; set; }
    }
}
