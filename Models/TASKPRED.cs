namespace Models
{
    public class TASKPRED
    {
        public int task_pred_id { get; set; }
        public int task_id { get; set; }
        public int pred_task_id { get; set; }
        public int proj_id { get; set; }
        public int pred_proj_id { get; set; }
        public string pred_type { get; set; }
        public decimal? lag_hr_cnt { get; set; }
        public string? float_path { get; set; }
        public DateTime? aref { get; set; }
        public DateTime? arls { get; set; }
    }
}