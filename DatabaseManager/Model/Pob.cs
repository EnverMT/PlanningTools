using System;
using System.Collections.Generic;

namespace DatabaseManager.Model
{
    public partial class Pob
    {
        public long PobsId { get; set; }
        public long? PobsParentId { get; set; }
        public long? SeqNum { get; set; }
        public string? PobsName { get; set; }
        public string? PobsDescr { get; set; }
        public string? PobsManager { get; set; }
        public byte[]? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public byte[]? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public long? DeleteSessionId { get; set; }
        public byte[]? DeleteDate { get; set; }
    }
}
