namespace DatabaseManager.Model
{
    public partial class Udftype
    {
        public long UdfTypeId { get; set; }
        public string? TableName { get; set; }
        public string? UdfTypeName { get; set; }
        public string? UdfTypeLabel { get; set; }
        public string? LogicalDataType { get; set; }
        public string? SuperFlag { get; set; }
        public string? IndicatorExpression { get; set; }
        public string? SummaryIndicatorExpression { get; set; }
        public string? Formula { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public long? DeleteSessionId { get; set; }
        public DateTime? DeleteDate { get; set; }
    }
}
