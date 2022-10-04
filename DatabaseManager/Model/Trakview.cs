namespace DatabaseManager.Model
{
    public partial class Trakview
    {
        public long TrackViewId { get; set; }
        public long? UserId { get; set; }
        public string? DisplayType { get; set; }
        public string? TrackViewName { get; set; }
        public string? WebViewFlag { get; set; }
        public byte[]? TrackViewData { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public long? DeleteSessionId { get; set; }
        public DateTime? DeleteDate { get; set; }
    }
}
