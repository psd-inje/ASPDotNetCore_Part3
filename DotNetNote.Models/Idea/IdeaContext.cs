using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace DotNetNote.Models
{
    public class IdeaContext : DbContext
    {
        public IdeaContext()
        {
            // Empty
        }

        public IdeaContext(DbContextOptions<IdeaContext> options) 
            : base(options)
        {
            // 공식과 같은 코드 
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        public DbSet<Idea> Ideas { get; set; }


        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);

        //    modelBuilder.Entity<Tech>().HasData(
        //        new Tech { Id = 1, Title = "ASP.NET" },
        //        new Tech { Id = 2, Title = "Blazor" });
        //}



    }
}
