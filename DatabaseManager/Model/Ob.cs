using System;
using System.Collections.Generic;

namespace DatabaseManager.Model
{
    public partial class Ob
    {
        public long ObsId { get; set; }
        public long? ParentObsId { get; set; }
        public string? Guid { get; set; }
        public long? SeqNum { get; set; }
        public string? ObsName { get; set; }
        public byte[]? ObsDescr { get; set; }
        public byte[]? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public byte[]? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public long? DeleteSessionId { get; set; }
        public byte[]? DeleteDate { get; set; }
    }
}
