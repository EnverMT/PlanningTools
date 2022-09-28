namespace XerParser.Models.Classes
{
    public class RSRC
    {
        public int rsrc_id { get; set; }
        public int? parent_rsrc_id { get; set; }
        public int? clndr_id { get; set; }
        public int? role_id { get; set; }
        public int? shift_id { get; set; }
        public int? user_id { get; set; }
        public int? pobs_id { get; set; }
        public string? guid { get; set; }
        public string? rsrc_seq_num { get; set; }
        public string? email_addr { get; set; }
        public string? employee_code { get; set; }
        public string? office_phone { get; set; }
        public string? other_phone { get; set; }
        public string? rsrc_name { get; set; }
        public string? rsrc_short_name { get; set; }
        public string? rsrc_title_name { get; set; }
        public string? def_qty_per_hr { get; set; }
        public string? cost_qty_type { get; set; }
        public string? ot_factor { get; set; }
        public string? active_flag { get; set; }
        public string? auto_compute_act_flag { get; set; }
        public string? def_cost_qty_link_flag { get; set; }
        public string? ot_flag { get; set; }
        public string? curr_id { get; set; }
        public string? unit_id { get; set; }
        public string? rsrc_type { get; set; }
        public string? location_id { get; set; }
        public string? ts_approve_user_id { get; set; }
        public string? timesheet_flag { get; set; }
        public string? rsrc_notes { get; set; }
        public string? load_tasks_flag { get; set; }
        public string? level_flag { get; set; }
        public string? last_checksum { get; set; }
    }
}
