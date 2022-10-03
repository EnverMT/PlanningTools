using System;
using System.Collections.Generic;

namespace DatabaseManager.Model
{
    public partial class Discussion
    {
        public long DiscussionId { get; set; }
        public long? TaskId { get; set; }
        public long? UserId { get; set; }
        public string? DiscussionValue { get; set; }
        public byte[]? DiscussionDate { get; set; }
        public byte[]? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public byte[]? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public long? DeleteSessionId { get; set; }
        public byte[]? DeleteDate { get; set; }
    }
}
