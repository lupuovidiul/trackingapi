using Microsoft.EntityFrameworkCore;
using trackingapi.Domain.Aggregates.Issue;

namespace trackingapi.Infrastructure.Data
{
    public class IssueDbContext : DbContext
    {
        public IssueDbContext(DbContextOptions<IssueDbContext> options) : base(options) { }

        public DbSet<IssueAggregate> Issues { get; set; }
    }
}
