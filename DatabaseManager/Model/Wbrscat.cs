﻿namespace DatabaseManager.Model
{
    public partial class Wbrscat
    {
        public long WbrsCatId { get; set; }
        public string? WbrsCatName { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public long? DeleteSessionId { get; set; }
        public DateTime? DeleteDate { get; set; }
    }
}
