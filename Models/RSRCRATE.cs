namespace Models
{
    public class RSRCRATE
    {
        public int rsrc_rate_id { get; set; }
        public int rsrc_id { get; set; }
        public double max_qty_per_hr { get; set; }
        public double cost_per_qty { get; set; }
        public DateTime start_date { get; set; }
        public string? shift_period_id { get; set; }
        public double? cost_per_qty2 { get; set; }
        public double? cost_per_qty3 { get; set; }
        public double? cost_per_qty4 { get; set; }
        public double? cost_per_qty5 { get; set; }
    }
}