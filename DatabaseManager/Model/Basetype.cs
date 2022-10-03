using System;
using System.Collections.Generic;

namespace DatabaseManager.Model
{
    public partial class Basetype
    {
        public long BaseTypeId { get; set; }
        public long? BaseTypeSeqNum { get; set; }
        public string? BaseType1 { get; set; }
        public byte[]? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public byte[]? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public long? DeleteSessionId { get; set; }
        public byte[]? DeleteDate { get; set; }
    }
}
