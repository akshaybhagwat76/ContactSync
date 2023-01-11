using Microsoft.EntityFrameworkCore;

namespace ContactsSync.Database
{
    public class ContactsSyncContext : DbContext
    {
        public ContactsSyncContext(DbContextOptions<ContactsSyncContext> options):base(options)
        {

        }
        public DbSet<AllContracts> AllContracts { get; set; }

    }
}
