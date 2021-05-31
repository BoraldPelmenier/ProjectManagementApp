using Microsoft.EntityFrameworkCore;
using Entities;

namespace Data.DbContexts
{
    public class ProjectContext : DbContext
    {
        public DbSet<ProjectEntity> Projects { get; set; }
        public DbSet<UserEntity> Users { get; set; }

        public ProjectContext()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Projects;Trusted_Connection=True;");
        }
    }
}
