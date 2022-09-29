namespace XerParser.Models.Classes
{
    public class UDFVALUE
    {
       public int udf_type_id { get; set; }
       public int fk_id { get; set; }
       public int proj_id { get; set; }
       public DateTime? udf_date { get; set; }
       public decimal? udf_number { get; set; }
       public string? udf_text { get; set; }
       public int? udf_code_id { get; set; }
    }
}