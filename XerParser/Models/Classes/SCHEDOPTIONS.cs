namespace XerParser.Models.Classes
{
    public class SCHEDOPTIONS
    {
        public int schedoptions_id { get; set; }
        public int? proj_id { get; set; }
        public string? sched_outer_depend_type { get; set; }
        public string? sched_open_critical_flag { get; set; }
        public string? sched_lag_early_start_flag { get; set; }
        public string? sched_retained_logic { get; set; }
        public string? sched_setplantoforecast { get; set; }
        public string? sched_float_type { get; set; }
        public string? sched_calendar_on_relationship_lag { get; set; }
        public string? sched_use_expect_end_flag { get; set; }
        public string? sched_progress_override { get; set; }
        public string? level_float_thrs_cnt { get; set; }
        public string? level_outer_assign_flag { get; set; }
        public string? level_outer_assign_priority { get; set; }
        public string? level_over_alloc_pct { get; set; }
        public string? level_within_float_flag { get; set; }
        public string? level_keep_sched_date_flag { get; set; }
        public string? level_all_rsrc_flag { get; set; }
        public string? sched_use_project_end_date_for_float { get; set; }
        public string? enable_multiple_longest_path_calc { get; set; }
        public string? limit_multiple_longest_path_calc { get; set; }
        public string? max_multiple_longest_path { get; set; }
        public string? use_total_float_multiple_longest_paths { get; set; }
        public string? key_activity_for_multiple_longest_paths { get; set; }
        public string? LevelPriorityList { get; set; }

    }
}