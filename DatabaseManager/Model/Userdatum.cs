using System;
using System.Collections.Generic;

namespace DatabaseManager.Model
{
    public partial class Userdatum
    {
        public long UserDataId { get; set; }
        public long? UserId { get; set; }
        public string? TopicName { get; set; }
        public byte[]? UserData { get; set; }
        public byte[]? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public byte[]? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public long? DeleteSessionId { get; set; }
        public byte[]? DeleteDate { get; set; }
    }
}
