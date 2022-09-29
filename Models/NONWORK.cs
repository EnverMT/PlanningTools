using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class NONWORK
    {
        [Key]
        public int nonwork_type_id { get; set; }
        public int seq_num { get; set; }
        public string? nonwork_code { get; set; }
        public string? nonwork_type { get; set; }

    }
}