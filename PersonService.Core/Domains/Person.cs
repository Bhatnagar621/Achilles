using Achilles.Core.Domains;

namespace PersonService.Core.Domains
{
    public class Person : BaseDomain
    {
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Email { get; set; }
    }
}
