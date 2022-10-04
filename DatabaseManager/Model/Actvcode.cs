using CsvHelper.Configuration.Attributes;

namespace DatabaseManager.Model
{
    public partial class Actvcode
    {
        [Name("actv_code_id")]
        public long ActvCodeId { get; set; }
        
        [Name("parent_actv_code_id")]
        public long? ParentActvCodeId { get; set; }
        
        [Name("actv_code_type_id")]
        public long? ActvCodeTypeId { get; set; }
        
        [Name("actv_code_name")]
        public string? ActvCodeName { get; set; }

        [Name("short_name")]
        public string? ShortName { get; set; }

        [Name("seq_num")]
        public long? SeqNum { get; set; }

        [Name("color")]
        public string? Color { get; set; }
        
        [Ignore]
        public DateTime? CreateDate { get; set; }

        [Ignore]
        public string? CreateUser { get; set; }

        [Ignore]
        public DateTime? UpdateDate { get; set; }

        [Ignore]
        public string? UpdateUser { get; set; }

        [Ignore]
        public long? DeleteSessionId { get; set; }

        [Ignore]
        public DateTime? DeleteDate { get; set; }
    }
}
