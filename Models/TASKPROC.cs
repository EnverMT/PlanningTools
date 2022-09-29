using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class TASKPROC
    {
        [Key]
        public int proc_id { get; set; }
        public int task_id { get; set; }
        public int proj_id { get; set; }
        public int seq_num { get; set; }
        public string proc_name { get; set; }
        public string complete_flag { get; set; }
        public decimal? proc_wt { get; set; }
        public decimal? complete_pct { get; set; }
        public string? proc_descr { get; set; }
    }
}