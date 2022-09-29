namespace Models
{
    public class CALENDAR
    {
        public int clndr_id { get; set; }
        public string? default_flag { get; set; }
        public string? clndr_name { get; set; }
        public int? proj_id { get; set; }
        public int? base_clndr_id { get; set; }
        public DateTime? last_chng_date { get; set; }
        public string? clndr_type { get; set; }
        public int? day_hr_cnt { get; set; }
        public int? week_hr_cnt { get; set; }
        public int? month_hr_cnt { get; set; }
        public int? year_hr_cnt { get; set; }
        public string? rsrc_private { get; set; }
        public string? clndr_data { get; set; }
    }
}




