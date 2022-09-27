namespace XerParser.Models
{
    public class Currtype
    {
        public int curr_id { get; set; }
        public int decimal_digit_cnt { get; set; }
        public string? curr_symbol { get; set; }
        public string? decimal_symbol { get; set; }
        public string? digit_group_symbol { get; set; }
        public string? pos_curr_fmt_type { get; set; }
        public string? neg_curr_fmt_type { get; set; }
        public string? curr_type { get; set; }
        public string? curr_short_name { get; set; }
        public int group_digit_cnt { get; set; }
        public double base_exch_rate { get; set; }
    }
}
