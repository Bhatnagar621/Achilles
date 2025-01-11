using Microsoft.EntityFrameworkCore;
namespace Achilles.Infrastructure.DbContexts
{
    public class BaseDbContext: DbContext
    {
        public BaseDbContext(DbContextOptions<BaseDbContext> options) : base(options)
        {
        }
    }
}
