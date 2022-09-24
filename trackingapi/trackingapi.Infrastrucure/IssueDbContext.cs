using Microsoft.EntityFrameworkCore;
using trackingapi.Domain;

namespace trackingapi.Infrastructure
{
    public class IssueDbContext : DbContext
    {
        public IssueDbContext(DbContextOptions<IssueDbContext> options) : base(options) { }

        public DbSet<Epic> Epics { get; set; }
        public DbSet<Bug> Bugs { get; set; }
        public DbSet<Story> Stories { get; set; }
        public DbSet<Domain.Task> Tasks { get; set; }
    }
}
