using BlogSite.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace BlogSite.DataAccess.Configurations;
public class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.ToTable("Categories").HasKey(x => x.Id);
        builder.Property(x => x.Id).HasColumnName("CategoryId");
        builder.Property(x => x.CreatedDate).HasColumnName("CreatedTime");
        builder.Property(x => x.UpdatedDate).HasColumnName("UpdatedTime");
        builder.Property(x => x.Name).HasColumnName("CategoryName");
        builder
            .HasMany(x => x.Posts)
            .WithOne(x => x.Category)
            .HasForeignKey(x => x.Id)
            .OnDelete(DeleteBehavior.NoAction);
        builder.HasData(new Category
        {
            Id = 1,
            CreatedDate = DateTime.Now,
            Name = "Yazılım",
        });
    }
}