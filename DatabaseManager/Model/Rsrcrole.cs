using System;
using System.Collections.Generic;

namespace DatabaseManager.Model
{
    public partial class Rsrcrole
    {
        public long RsrcId { get; set; }
        public long RoleId { get; set; }
        public long? SkillLevel { get; set; }
        public byte[]? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public byte[]? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public long? DeleteSessionId { get; set; }
        public byte[]? DeleteDate { get; set; }
    }
}
