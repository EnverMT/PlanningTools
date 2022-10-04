namespace DatabaseManager.Model
{
    public partial class Taskdoc
    {
        public long TaskdocId { get; set; }
        public long? DocId { get; set; }
        public long? ProjId { get; set; }
        public long? WbsId { get; set; }
        public string? WpFlag { get; set; }
        public long? TaskId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public long? DeleteSessionId { get; set; }
        public DateTime? DeleteDate { get; set; }
    }
}
