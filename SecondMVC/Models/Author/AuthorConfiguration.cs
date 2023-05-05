using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SecondMVC.Models
{
    public class AuthorConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.ToTable("Author");
            builder.HasKey(i => i.Id);
            builder.Property(i => i.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Property(i => i.Name).IsRequired().
                HasMaxLength(100).HasColumnName("NameOfAuthor");
        }
    }
}
