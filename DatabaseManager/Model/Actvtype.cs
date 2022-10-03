﻿namespace DatabaseManager.Model
{
    public partial class Actvtype
    {
        public long ActvCodeTypeId { get; set; }
        public long? ActvShortLen { get; set; }
        public long? SeqNum { get; set; }
        public string? ActvCodeType { get; set; }
        public long? ProjId { get; set; }
        public string? SuperFlag { get; set; }
        public string? ActvCodeTypeScope { get; set; }
        public byte[]? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public byte[]? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public long? DeleteSessionId { get; set; }
        public byte[]? DeleteDate { get; set; }
    }
}
