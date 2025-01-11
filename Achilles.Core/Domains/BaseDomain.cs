namespace Achilles.Core.Domains
{
    public class BaseDomain
    {
        public Guid Id { get; set; }
        public Guid CreatedBy { get; set; } = Guid.Empty;
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
    }
}
