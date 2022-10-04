namespace DatabaseManager.Model
{
    public partial class Projprop
    {
        public long ProjId { get; set; }
        public string PropName { get; set; } = null!;
        public byte[]? PropValue { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public long? DeleteSessionId { get; set; }
        public DateTime? DeleteDate { get; set; }
    }
}
