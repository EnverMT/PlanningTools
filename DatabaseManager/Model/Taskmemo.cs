using System;
using System.Collections.Generic;

namespace DatabaseManager.Model
{
    public partial class Taskmemo
    {
        public long MemoId { get; set; }
        public long? TaskId { get; set; }
        public long? MemoTypeId { get; set; }
        public long? ProjId { get; set; }
        public byte[]? TaskMemo1 { get; set; }
        public byte[]? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public byte[]? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public long? DeleteSessionId { get; set; }
        public byte[]? DeleteDate { get; set; }
    }
}
