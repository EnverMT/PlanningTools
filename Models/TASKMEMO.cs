using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class TASKMEMO
    {
        [Key]
        public int memo_id { get; set; }
        public int task_id { get; set; }
        public int memo_type_id { get; set; }
        public int proj_id { get; set; }
        public string? task_memo { get; set; }
    }
}