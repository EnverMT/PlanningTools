namespace XerParser.Models.Classes
{
    public class TASKRSRC
    {
        public int taskrsrc_id { get; set; }
        public int task_id { get; set; }
        public int proj_id { get; set; }
        public string cost_qty_link_flag { get; set; }
        public int? role_id { get; set; }
        public int? acct_id { get; set; }
        public int? rsrc_id { get; set; }
        public int? pobs_id { get; set; }
        public int? skill_level { get; set; }
        public decimal? remain_qty { get; set; }
        public decimal? target_qty { get; set; }
        public decimal? remain_qty_per_hr { get; set; }
        public decimal? target_lag_drtn_hr_cnt { get; set; }
        public decimal? target_qty_per_hr { get; set; }
        public decimal? act_ot_qty { get; set; }
        public decimal? act_reg_qty { get; set; }
        public decimal? relag_drtn_hr_cnt { get; set; }
        public decimal? ot_factor { get; set; }
        public decimal? cost_per_qty { get; set; }
        public decimal? target_cost { get; set; }
        public decimal? act_reg_cost { get; set; }
        public decimal? act_ot_cost { get; set; }
        public decimal? remain_cost { get; set; }
        public DateTime? act_start_date { get; set; }
        public DateTime? act_end_date { get; set; }
        public DateTime? restart_date { get; set; }
        public DateTime? reend_date { get; set; }
        public DateTime? target_start_date { get; set; }
        public DateTime? target_end_date { get; set; }
        public DateTime? rem_late_start_date { get; set; }
        public DateTime? rem_late_end_date { get; set; }
        public string? rollup_dates_flag { get; set; }
        public string? target_crv { get; set; }
        public string? remain_crv { get; set; }
        public string? actual_crv { get; set; }
        public string? ts_pend_act_end_flag { get; set; }
        public string? guid { get; set; }
        public string? rate_type { get; set; }
        public decimal? act_this_per_cost { get; set; }
        public decimal? act_this_per_qty { get; set; }
        public int? curv_id { get; set; }
        public string rsrc_type { get; set; }
        public string? cost_per_qty_source_type { get; set; }
        public string? create_user { get; set; }
        public DateTime? create_date { get; set; }
        public string? cbs_id { get; set; }
        public string? has_rsrchours { get; set; }
        public string? taskrsrc_sum_id { get; set; }
    }
}