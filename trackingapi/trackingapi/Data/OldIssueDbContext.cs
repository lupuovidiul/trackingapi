using Microsoft.EntityFrameworkCore;
using trackingapi.Models;

namespace trackingapi.Data
{
    public class OldIssueDbContext : DbContext
    {
        public OldIssueDbContext(DbContextOptions<OldIssueDbContext> options) : base(options)
        {
        }
        
        public DbSet<Issue> Issues { get; set; }
    }
}
