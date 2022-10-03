using System;
using System.Collections.Generic;

namespace DatabaseManager.Model
{
    public partial class Actvcode
    {
        public long ActvCodeId { get; set; }
        public long? ParentActvCodeId { get; set; }
        public long? ActvCodeTypeId { get; set; }
        public string? ActvCodeName { get; set; }
        public string? ShortName { get; set; }
        public long? SeqNum { get; set; }
        public string? Color { get; set; }
        public byte[]? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public byte[]? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public long? DeleteSessionId { get; set; }
        public byte[]? DeleteDate { get; set; }
    }
}
