using System;
using System.Collections.Generic;

namespace DatabaseManager.Model
{
    public partial class Projprop
    {
        public long ProjId { get; set; }
        public string PropName { get; set; } = null!;
        public byte[]? PropValue { get; set; }
        public byte[]? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public byte[]? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public long? DeleteSessionId { get; set; }
        public byte[]? DeleteDate { get; set; }
    }
}
