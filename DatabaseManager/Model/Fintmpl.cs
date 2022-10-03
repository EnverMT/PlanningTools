namespace DatabaseManager.Model
{
    public partial class Fintmpl
    {
        public Fintmpl()
        {
            Findates = new HashSet<Findate>();
            Projects = new HashSet<Project>();
        }

        public byte[] FintmplId { get; set; } = null!;
        public string? FintmplName { get; set; }
        public string? DefaultFlag { get; set; }
        public byte[]? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public byte[]? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public byte[]? DeleteSessionId { get; set; }
        public byte[]? DeleteDate { get; set; }

        public virtual ICollection<Findate> Findates { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
    }
}
