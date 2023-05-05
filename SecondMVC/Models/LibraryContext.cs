using Microsoft.EntityFrameworkCore;
using MVC_Lab2.Models;
using QenaQ2MVC.Models;

namespace SecondMVC.Models
{
    public class LibraryContext:DbContext
    {

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Image> Images { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new AuthorConfiguration().Configure(modelBuilder.Entity<Author>());
            new BookConfiguration().Configure(modelBuilder.Entity<Book>());
            new ImageConfiguration().Configure(modelBuilder.Entity<Image>());
            
            modelBuilder.MapRelationship();

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Data Source=.;Initial Catalog=MVC-TASK; Integrated Security=True; TrustServerCertificate=True");
        }
    }
}
