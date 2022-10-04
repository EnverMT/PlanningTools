﻿namespace DatabaseManager.Model
{
    public partial class Pcattype
    {
        public long ProjCatgTypeId { get; set; }
        public long? SeqNum { get; set; }
        public long? ProjCatgShortLen { get; set; }
        public string? ProjCatgType { get; set; }
        public string? SuperFlag { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public long? DeleteSessionId { get; set; }
        public DateTime? DeleteDate { get; set; }
    }
}
