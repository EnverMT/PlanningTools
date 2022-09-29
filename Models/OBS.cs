namespace Models
{
    public class OBS
    {
        public int obs_id { get; set; }
        public int? parent_obs_id { get; set; }
        public string? guid { get; set; }
        public int seq_num { get; set; }
        public string? obs_name { get; set; }
        public string? obs_descr { get; set; }
    }
}