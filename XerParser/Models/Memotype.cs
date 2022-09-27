namespace XerParser.Models
{
    public class Memotype
    {
        public int memo_type_id { get; set; }
        public int seq_num { get; set; }
        public string? proj_flag { get; set; }
        public string? wbs_flag { get; set; }
        public string? task_flag { get; set; }
        public string? memo_type { get; set; }
    }
}