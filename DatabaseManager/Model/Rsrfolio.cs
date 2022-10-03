﻿namespace DatabaseManager.Model
{
    public partial class Rsrfolio
    {
        public long RfolioId { get; set; }
        public long RsrcId { get; set; }
        public byte[]? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public byte[]? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public long? DeleteSessionId { get; set; }
        public byte[]? DeleteDate { get; set; }
    }
}