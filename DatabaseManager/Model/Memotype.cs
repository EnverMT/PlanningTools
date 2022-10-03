using System;
using System.Collections.Generic;

namespace DatabaseManager.Model
{
    public partial class Memotype
    {
        public long MemoTypeId { get; set; }
        public long? SeqNum { get; set; }
        public string? EpsFlag { get; set; }
        public string? ProjFlag { get; set; }
        public string? WbsFlag { get; set; }
        public string? TaskFlag { get; set; }
        public string? MemoType1 { get; set; }
        public byte[]? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public byte[]? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public long? DeleteSessionId { get; set; }
        public byte[]? DeleteDate { get; set; }
    }
}
