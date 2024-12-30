using Microsoft.EntityFrameworkCore;
using UdemyBookStoreProject.Models.Models;

namespace UdemyBookStoreProject.DataAccess
{
    public class ApplicationDbcontext : DbContext
    {
        public ApplicationDbcontext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Category>categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Shaunak", DisplayOrder = 1 },
                new Category { Id = 2, Name = "shukla", DisplayOrder = 2 },
               new Category { Id = 3, Name = "shuklaji", DisplayOrder = 3 }
                );
        }
    }
}
