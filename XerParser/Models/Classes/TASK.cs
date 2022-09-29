using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace XerParser.Models.Classes
{
    public class TASK
    {
        #region Fields
        [Key]
        public int task_id { get; set; }
        public int? proj_id { get; set; }
        public int? wbs_id { get; set; }
        public int? clndr_id { get; set; }
        public double? phys_complete_pct { get; set; }
        public string? rev_fdbk_flag { get; set; }
        public double? est_wt { get; set; }
        public string? lock_plan_flag { get; set; }
        public string? auto_compute_act_flag { get; set; }
        public string? complete_pct_type { get; set; }
        public string? task_type { get; set; }
        public string? duration_type { get; set; }
        public string? status_code { get; set; }
        public string? task_code { get; set; }
        public string? task_name { get; set; }
        public int? rsrc_id { get; set; }
        public double? total_float_hr_cnt { get; set; }
        public double? free_float_hr_cnt { get; set; }
        public double? remain_drtn_hr_cnt { get; set; }
        public double? act_work_qty { get; set; }
        public double? remain_work_qty { get; set; }
        public double? target_work_qty { get; set; }
        public double? target_drtn_hr_cnt { get; set; }
        public double? target_equip_qty { get; set; }
        public double? act_equip_qty { get; set; }
        public double? remain_equip_qty { get; set; }
        [Column(TypeName = "DATETIME")]
        public DateTime? cstr_date { get; set; }
        [Column(TypeName = "DATETIME")]
        public DateTime? act_start_date { get; set; }
        [Column(TypeName = "DATETIME")]
        public DateTime? act_end_date { get; set; }
        [Column(TypeName = "DATETIME")]
        public DateTime? late_start_date { get; set; }
        [Column(TypeName = "DATETIME")]
        public DateTime? late_end_date { get; set; }
        [Column(TypeName = "DATETIME")]
        public DateTime? expect_end_date { get; set; }
        [Column(TypeName = "DATETIME")]
        public DateTime? early_start_date { get; set; }
        [Column(TypeName = "DATETIME")]
        public DateTime? early_end_date { get; set; }
        [Column(TypeName = "DATETIME")]
        public DateTime? restart_date { get; set; }
        [Column(TypeName = "DATETIME")]
        public DateTime? reend_date { get; set; }
        [Column(TypeName = "DATETIME")]
        public DateTime? target_start_date { get; set; }
        [Column(TypeName = "DATETIME")]
        public DateTime? target_end_date { get; set; }
        [Column(TypeName = "DATETIME")]
        public DateTime? rem_late_start_date { get; set; }
        [Column(TypeName = "DATETIME")]
        public DateTime? rem_late_end_date { get; set; }
        public string? cstr_type { get; set; }
        public string? priority_type { get; set; }
        [Column(TypeName = "DATETIME")]
        public DateTime? suspend_date { get; set; }
        [Column(TypeName = "DATETIME")]
        public DateTime? resume_date { get; set; }
        public string? float_path { get; set; }
        public string? float_path_order { get; set; }
        public string? guid { get; set; }
        public string? tmpl_guid { get; set; }
        [Column(TypeName = "DATETIME")]
        public DateTime? cstr_date2 { get; set; }
        public string? cstr_type2 { get; set; }
        public string? driving_path_flag { get; set; }
        public double? act_this_per_work_qty { get; set; }
        public double? act_this_per_equip_qty { get; set; }
        [Column(TypeName = "DATETIME")]
        public DateTime? external_early_start_date { get; set; }
        [Column(TypeName = "DATETIME")]
        public DateTime? external_late_end_date { get; set; }
        public string? cbs_id { get; set; }
        [Column(TypeName = "DATETIME")]
        public DateTime? pre_pess_start_date { get; set; }
        [Column(TypeName = "DATETIME")]
        public DateTime? pre_pess_finish_date { get; set; }
        [Column(TypeName = "DATETIME")]
        public DateTime? post_pess_start_date { get; set; }
        [Column(TypeName = "DATETIME")]
        public DateTime? post_pess_finish_date { get; set; }
        [Column(TypeName = "DATETIME")]
        public DateTime? create_date { get; set; }
        [Column(TypeName = "DATETIME")]
        public DateTime? update_date { get; set; }
        public string? create_user { get; set; }
        public string? update_user { get; set; }
        public int? location_id { get; set; }
        public string? control_updates_flag { get; set; }
        #endregion
    }
}