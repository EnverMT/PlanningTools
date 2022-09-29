using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class PROJECT
    {
        [Key]
        public int proj_id { get; set; }
        public int fy_start_month_num { get; set; }
        public string? rsrc_self_add_flag { get; set; }
        public string? allow_complete_flag { get; set; }
        public string? rsrc_multi_assign_flag { get; set; }
        public string? checkout_flag { get; set; }
        public string? project_flag { get; set; }
        public string? step_complete_flag { get; set; }
        public string? cost_qty_recalc_flag { get; set; }
        public string? batch_sum_flag { get; set; }
        public string? name_sep_char { get; set; }
        public string? def_complete_pct_type { get; set; }
        public string? proj_short_name { get; set; }
        public string? acct_id { get; set; }
        public string? orig_proj_id { get; set; }
        public string? source_proj_id { get; set; }
        public string? base_type_id { get; set; }
        public int? clndr_id { get; set; }
        public int? sum_base_proj_id { get; set; }
        public int? task_code_base { get; set; }
        public int? task_code_step { get; set; }
        public int? priority_num { get; set; }
        public string? wbs_max_sum_level { get; set; }
        public string? strgy_priority_num { get; set; }
        public string? last_checksum { get; set; }
        public int? critical_drtn_hr_cnt { get; set; }
        public double? def_cost_per_qty { get; set; }
        public DateTime? last_recalc_date { get; set; }
        public DateTime? plan_start_date { get; set; }
        public DateTime? plan_end_date { get; set; }
        public DateTime? scd_end_date { get; set; }
        public DateTime? add_date { get; set; }
        public DateTime? last_tasksum_date { get; set; }
        public DateTime? fcst_start_date { get; set; }
        public string? def_duration_type { get; set; }
        public string? task_code_prefix { get; set; }
        public string? guid { get; set; }
        public string? def_qty_type { get; set; }
        public string? add_by_name { get; set; }
        public string? web_local_root_path { get; set; }
        public string? proj_url { get; set; }
        public string? def_rate_type { get; set; }
        public string? add_act_remain_flag { get; set; }
        public string? act_this_per_link_flag { get; set; }
        public string? def_task_type { get; set; }
        public string? act_pct_link_flag { get; set; }
        public string? critical_path_type { get; set; }
        public string? task_code_prefix_flag { get; set; }
        public string? def_rollup_dates_flag { get; set; }
        public string? use_project_baseline_flag { get; set; }
        public string? rem_target_link_flag { get; set; }
        public string? reset_planned_flag { get; set; }
        public string? allow_neg_act_flag { get; set; }
        public string? sum_assign_level { get; set; }
        public string? last_fin_dates_id { get; set; }
        public string? last_baseline_update_date { get; set; }
        public string? cr_external_key { get; set; }
        public string? apply_actuals_date { get; set; }
        public string? matrix_id { get; set; }
        public string? last_level_date { get; set; }
        public string? last_schedule_date { get; set; }
        public string? px_enable_publication_flag { get; set; }
        public string? px_last_update_date { get; set; }
        public string? px_priority { get; set; }
        public string? control_updates_flag { get; set; }
        public string? hist_interval { get; set; }
        public string? hist_level { get; set; }
        public string? schedule_type { get; set; }
        public string? location_id { get; set; }
        public string? loaded_scope_level { get; set; }
        public string? export_flag { get; set; }
        public string? new_fin_dates_id { get; set; }
        public string? baselines_to_export { get; set; }
        public string? baseline_names_to_export { get; set; }
        public string? sync_wbs_heir_flag { get; set; }
        public string? sched_wbs_heir_type { get; set; }
        public string? wbs_heir_levels { get; set; }
        public string? next_data_date { get; set; }
        public string? close_period_flag { get; set; }
        public string? sum_refresh_date { get; set; }
        public string? trsrcsum_loaded { get; set; }
    }
}