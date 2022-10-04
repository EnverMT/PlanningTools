namespace DatabaseManager.Model
{
    public partial class Pfolio
    {
        public long PfolioId { get; set; }
        public long? UserId { get; set; }
        public string? PfolioType { get; set; }
        public string? PfolioName { get; set; }
        public string? PfolioDescr { get; set; }
        public string? ClosedProjFlag { get; set; }
        public string? WhatifProjFlag { get; set; }
        public byte[]? PfolioData { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public long? DeleteSessionId { get; set; }
        public DateTime? DeleteDate { get; set; }
    }
}
