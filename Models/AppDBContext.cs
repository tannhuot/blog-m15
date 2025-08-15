using Microsoft.EntityFrameworkCore;

namespace blog_m15.Models
{
    public class AppDBContext(IConfiguration configuration) : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("conn"));
        }

        public DbSet<CategoryEntiry> Categories { get; set; }
        public DbSet<TagEntity> Tags { get; set; }
        public DbSet<PostEntity> Posts { get; set; }
    }
}
