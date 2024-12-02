using BUMS.Areas.Identity.Data;
using Microsoft.EntityFrameworkCore;

namespace BUMS{
    public class BUMSDbContext : DbContext{
        public BUMSDbContext(DbContextOptions<BUMSDbContext> options) : base(options) { 
        }
        
        public DbSet<User> Users { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Access> Accesss { get; set; }
        public DbSet<UserGroup> UserGroups { get; set; }
    }
}
