using System;
using System.Collections.Generic;

namespace DatabaseManager.Model
{
    public partial class Refrdel
    {
        public byte[]? DeleteDate { get; set; }
        public string? TableName { get; set; }
        public string? Pk1 { get; set; }
        public string? Pk2 { get; set; }
        public string? Pk3 { get; set; }
        public string? Pk4 { get; set; }
        public long? ProjId { get; set; }
    }
}
