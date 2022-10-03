using System;
using System.Collections.Generic;

namespace DatabaseManager.Model
{
    public partial class Rcatval
    {
        public long RsrcCatgId { get; set; }
        public long? RsrcCatgTypeId { get; set; }
        public long? SeqNum { get; set; }
        public string? RsrcCatgShortName { get; set; }
        public string? RsrcCatgName { get; set; }
        public long? ParentRsrcCatgId { get; set; }
        public byte[]? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public byte[]? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public long? DeleteSessionId { get; set; }
        public byte[]? DeleteDate { get; set; }
    }
}
