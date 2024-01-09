using Microsoft.EntityFrameworkCore;

namespace azure_webapp_mtest.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }

        public DbSet<Person> Persons { get; set; }
    }
}
