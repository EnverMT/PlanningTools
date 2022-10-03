using System;
using System.Collections.Generic;

namespace DatabaseManager.Model
{
    public partial class Profile
    {
        public long ProfId { get; set; }
        public string? DefaultFlag { get; set; }
        public string? SuperuserFlag { get; set; }
        public string? ScopeType { get; set; }
        public string? ProfName { get; set; }
        public byte[]? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public byte[]? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public long? DeleteSessionId { get; set; }
        public byte[]? DeleteDate { get; set; }
    }
}
