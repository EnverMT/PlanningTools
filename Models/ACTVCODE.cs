using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class ACTVCODE
    {
        [Key]
        public int actv_code_id { get; set; }
        public int? parent_actv_code_id { get; set; }
        public int actv_code_type_id { get; set; }
        public string? actv_code_name { get; set; }
        public string? short_name { get; set; }
        public int seq_num { get; set; }
        public string? color { get; set; }
        public int? total_assignments { get; set; }
    }
}