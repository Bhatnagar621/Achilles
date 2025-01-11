using Microsoft.EntityFrameworkCore;
using PersonService.Core.Domains;

namespace PersonService.Infrastructure.PersonDbContext
{
    public class PersonDbContext : DbContext
    {
        public PersonDbContext(DbContextOptions<PersonDbContext> options) : base(options)
        {
            
        }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Authentication> Authentications { get; set; }
    }
}
