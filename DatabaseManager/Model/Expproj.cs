using System;
using System.Collections.Generic;

namespace DatabaseManager.Model
{
    public partial class Expproj
    {
        public long ProjId { get; set; }
        public string? ExpGroup { get; set; }
        public string? ExpProjName { get; set; }
        public string? LoginSuppliedFlag { get; set; }
        public string? ExpUserName { get; set; }
        public string? ExpPasswd { get; set; }
        public byte[]? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public byte[]? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public long? DeleteSessionId { get; set; }
        public byte[]? DeleteDate { get; set; }
    }
}
