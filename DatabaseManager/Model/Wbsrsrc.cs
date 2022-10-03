using System;
using System.Collections.Generic;

namespace DatabaseManager.Model
{
    public partial class Wbsrsrc
    {
        public long WbsrsrcId { get; set; }
        public long? WbsId { get; set; }
        public long? RsrcId { get; set; }
        public long? RoleId { get; set; }
        public long? ProjId { get; set; }
        public byte[]? StartDate { get; set; }
        public byte[]? EndDate { get; set; }
        public string? CommittedFlag { get; set; }
        public string? AutoComputeDatesFlag { get; set; }
        public string? RsrcRequestData { get; set; }
        public long? WbrsCatId { get; set; }
        public byte[]? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public byte[]? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public long? DeleteSessionId { get; set; }
        public byte[]? DeleteDate { get; set; }
    }
}
