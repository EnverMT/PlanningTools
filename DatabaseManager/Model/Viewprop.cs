namespace DatabaseManager.Model
{
    public partial class Viewprop
    {
        public long ViewId { get; set; }
        public long? UserId { get; set; }
        public long? ProjId { get; set; }
        public string? ViewType { get; set; }
        public string? ViewName { get; set; }
        public byte[]? ViewData { get; set; }
        public byte[]? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public byte[]? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public long? DeleteSessionId { get; set; }
        public byte[]? DeleteDate { get; set; }
    }
}
