namespace DatabaseManager.Model
{
    public partial class Document
    {
        public long DocId { get; set; }
        public long? DocSeqNum { get; set; }
        public string? DelivFlag { get; set; }
        public string? DocName { get; set; }
        public long? ParentDocId { get; set; }
        public long? ProjId { get; set; }
        public long? DocStatusId { get; set; }
        public long? DocCatgId { get; set; }
        public DateTime? DocDate { get; set; }
        public string? VersionName { get; set; }
        public string? Guid { get; set; }
        public string? TmplGuid { get; set; }
        public string? DocShortName { get; set; }
        public string? AuthorName { get; set; }
        public string? PrivateLoc { get; set; }
        public string? PublicLoc { get; set; }
        public string? DocMgmtType { get; set; }
        public string? CrExternalDocKey { get; set; }
        public byte[]? DocContent { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public long? DeleteSessionId { get; set; }
        public DateTime? DeleteDate { get; set; }
    }
}
