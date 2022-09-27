namespace XerParser.Models.Classes
{
    public class RISKTYPE
    {
        public int risk_type_id { get; set; }
        public int? seq_num { get; set; }
        public string? risk_type { get; set; }
        public int? parent_risk_type_id { get; set; }
    }
}