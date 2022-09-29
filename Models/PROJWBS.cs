namespace Models
{
    public class PROJWBS
    {
        public int wbs_id { get; set; }
        public int? proj_id { get; set; }
        public int? obs_id { get; set; }
        public int? seq_num { get; set; }
        public int? est_wt { get; set; }
        public string? proj_node_flag { get; set; }
        public string? sum_data_flag { get; set; }
        public string? status_code { get; set; }
        public string? wbs_short_name { get; set; }
        public string? wbs_name { get; set; }
        public string? phase_id { get; set; }
        public int? parent_wbs_id { get; set; }
        public string? ev_user_pct { get; set; }
        public string? ev_etc_user_value { get; set; }
        public string? orig_cost { get; set; }
        public string? indep_remain_total_cost { get; set; }
        public string? ann_dscnt_rate_pct { get; set; }
        public string? dscnt_period_type { get; set; }
        public string? indep_remain_work_qty { get; set; }
        public string? anticip_start_date { get; set; }
        public string? anticip_end_date { get; set; }
        public string? ev_compute_type { get; set; }
        public string? ev_etc_compute_type { get; set; }
        public string? guid { get; set; }
        public string? tmpl_guid { get; set; }
        public string? status_reviewer { get; set; }
        public string? plan_open_state { get; set; }
    }
}