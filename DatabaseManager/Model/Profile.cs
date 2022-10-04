﻿namespace DatabaseManager.Model
{
    public partial class Profile
    {
        public long ProfId { get; set; }
        public string? DefaultFlag { get; set; }
        public string? SuperuserFlag { get; set; }
        public string? ScopeType { get; set; }
        public string? ProfName { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public long? DeleteSessionId { get; set; }
        public DateTime? DeleteDate { get; set; }
    }
}
