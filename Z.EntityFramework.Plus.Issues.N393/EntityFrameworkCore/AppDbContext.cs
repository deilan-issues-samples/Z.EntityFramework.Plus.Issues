using Microsoft.EntityFrameworkCore;
using Z.EntityFramework.Plus.Issues.N393.Entities;

namespace Z.EntityFramework.Plus.Issues.N393.EntityFrameworkCore
{
    public sealed class AppDbContext : DbContext
    {
        public DbSet<AuditEntry> AuditEntries { get; set; }
        public DbSet<AuditEntryProperty> AuditEntryProperties { get; set; }
        public DbSet<Student> Students { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
    }
}