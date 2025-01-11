using Achilles.Core.Domains;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonService.Core.Domains
{
    public class Authentication : BaseDomain
    {
        [ForeignKey("PersonId")]
        public Guid PersonId { get; set; }
        public Person Person { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
    }
}
