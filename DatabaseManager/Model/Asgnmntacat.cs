﻿namespace DatabaseManager.Model
{
    public partial class Asgnmntacat
    {
        public long TaskrsrcId { get; set; }
        public long AsgnmntCatgTypeId { get; set; }
        public long AsgnmntCatgId { get; set; }
        public long? ProjId { get; set; }
        public byte[]? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public byte[]? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public long? DeleteSessionId { get; set; }
        public byte[]? DeleteDate { get; set; }
    }
}