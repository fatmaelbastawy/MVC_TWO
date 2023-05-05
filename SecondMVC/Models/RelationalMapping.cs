using Microsoft.EntityFrameworkCore;
using MVC_Lab2.Models;

namespace QenaQ2MVC.Models
{
    public static class RelationalMapping
    {
        public static void MapRelationship(this ModelBuilder builder)
        {
            builder.Entity<Book>().HasOne(a => a.Author).
                WithMany(a => a.Books).
                HasForeignKey(i => i.AuthorId).
                IsRequired().OnDelete(DeleteBehavior.NoAction);

            builder.Entity<Image>().HasOne(a => a.Book).
                WithMany(a => a.Images).HasForeignKey(a => a.BookId).
                IsRequired().OnDelete(DeleteBehavior.NoAction);
        }
    }
}
