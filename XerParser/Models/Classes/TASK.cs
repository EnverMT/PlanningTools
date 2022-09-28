namespace XerParser.Models.Classes
{
    public class TASK
    {
        public int task_id { get; set; }
        public int proj_id { get; set; }
        public int wbs_id { get; set; }
        public int clndr_id { get; set; }
        public decimal? phys_complete_pct { get; set; }
        public string? rev_fdbk_flag { get; set; }
        public string? est_wt { get; set; }
        public string? lock_plan_flag { get; set; }
        public string? auto_compute_act_flag { get; set; }
        public string? complete_pct_type { get; set; }
        public string? task_type { get; set; }
        public string? duration_type { get; set; }
        public string? status_code { get; set; }
        public string? task_code { get; set; }
        public string? task_name { get; set; }
        public int? rsrc_id { get; set; }
        public decimal? total_float_hr_cnt { get; set; }
        public decimal? free_float_hr_cnt { get; set; }
        public decimal? remain_drtn_hr_cnt { get; set; }
        public decimal? act_work_qty { get; set; }
        public decimal? remain_work_qty { get; set; }
        public decimal? target_work_qty { get; set; }
        public decimal? target_drtn_hr_cnt { get; set; }
        public decimal? target_equip_qty { get; set; }
        public decimal? act_equip_qty { get; set; }
        public decimal? remain_equip_qty { get; set; }
        public DateTime? cstr_date { get; set; }
        public DateTime? act_start_date { get; set; }
        public DateTime? act_end_date { get; set; }
        public DateTime? late_start_date { get; set; }
        public DateTime? late_end_date { get; set; }
        public DateTime? expect_end_date { get; set; }
        public DateTime? early_start_date { get; set; }
        public DateTime? early_end_date { get; set; }
        public DateTime? restart_date { get; set; }
        public DateTime? reend_date { get; set; }
        public DateTime? target_start_date { get; set; }
        public DateTime? target_end_date { get; set; }
        public DateTime? rem_late_start_date { get; set; }
        public DateTime? rem_late_end_date { get; set; }
        public string? cstr_type { get; set; }
        public string? priority_type { get; set; }
        public DateTime? suspend_date { get; set; }
        public DateTime? resume_date { get; set; }
        public string? float_path { get; set; }
        public string? float_path_order { get; set; }
        public string? guid { get; set; }
        public string? tmpl_guid { get; set; }
        public DateTime? cstr_date2 { get; set; }
        public string? cstr_type2 { get; set; }
        public string? driving_path_flag { get; set; }
        public string? act_this_per_work_qty { get; set; }
        public string? act_this_per_equip_qty { get; set; }
        public DateTime? external_early_start_date { get; set; }
        public DateTime? external_late_end_date { get; set; }
        public string? cbs_id { get; set; }
        public DateTime? pre_pess_start_date { get; set; }
        public DateTime? pre_pess_finish_date { get; set; }
        public DateTime? post_pess_start_date { get; set; }
        public DateTime? post_pess_finish_date { get; set; }
        public DateTime? create_date { get; set; }
        public DateTime? update_date { get; set; }
        public string? create_user { get; set; }
        public string? update_user { get; set; }
        public int? location_id { get; set; }
        public string? control_updates_flag { get; set; }

    }
}