using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class UDFTYPE
    {
        [Key]
        public int udf_type_id { get; set; }
        public string? table_name { get; set; }
        public string? udf_type_name { get; set; }
        public string? udf_type_label { get; set; }
        public string? logical_data_type { get; set; }
        public string? super_flag { get; set; }
        public string? indicator_expression { get; set; }
        public string? summary_indicator_expression { get; set; }
    }
}