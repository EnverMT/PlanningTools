using System;
using System.Collections.Generic;

namespace DatabaseManager.Model
{
    public partial class Udfcode
    {
        public long UdfCodeId { get; set; }
        public long? UdfTypeId { get; set; }
        public string? ShortName { get; set; }
        public string? UdfCodeName { get; set; }
        public byte[]? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public byte[]? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public long? DeleteSessionId { get; set; }
        public byte[]? DeleteDate { get; set; }
    }
}
