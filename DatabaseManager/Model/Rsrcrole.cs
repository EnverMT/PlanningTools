namespace DatabaseManager.Model
{
    public partial class Rsrcrole
    {
        public long RsrcId { get; set; }
        public long RoleId { get; set; }
        public long? SkillLevel { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public long? DeleteSessionId { get; set; }
        public DateTime? DeleteDate { get; set; }
    }
}
