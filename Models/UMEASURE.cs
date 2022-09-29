using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class UMEASURE
    {
        [Key]
        public int unit_id { get; set; }
        public int? seq_num { get; set; }
        public string? unit_abbrev { get; set; }
        public string? unit_name { get; set; }

    }
}