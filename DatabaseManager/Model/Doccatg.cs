using System;
using System.Collections.Generic;

namespace DatabaseManager.Model
{
    public partial class Doccatg
    {
        public long DocCatgId { get; set; }
        public long? SeqNum { get; set; }
        public string? DocCatgName { get; set; }
        public byte[]? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public byte[]? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public long? DeleteSessionId { get; set; }
        public byte[]? DeleteDate { get; set; }
    }
}
