using Lesson8_EF_SP_Join.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lesson8_EF_SP_Join.Configurations;

public class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder
            .Property(x => x.Name)
            .HasMaxLength(100)
            .IsRequired();

        builder
            .Property(x => x.Description)
            .HasMaxLength(100)
            .IsRequired(false);

        builder.HasData(GetCategories());
    }

    private List<Category> GetCategories()
    {
        return new List<Category>
        {
            new Category
            {
                Id = 1,
                Name = "Laptops",
                Description = "Laptop computers",
                CreatedDate = new DateTime(2025, 1, 1)
            },
            new Category
            {
                Id = 2,
                Name = "Smartphones",
                Description = "Mobile smartphones",
                CreatedDate = new DateTime(2025, 1, 2)
            },
            new Category
            {
                Id = 3,
                Name = "Tablets",
                Description = "Tablet computers",
                CreatedDate = new DateTime(2025, 1, 3)
            },
            new Category
            {
                Id = 4,
                Name = "Monitors",
                Description = "Computer monitors",
                CreatedDate = new DateTime(2025, 1, 4)
            },
            new Category
            {
                Id = 5,
                Name = "Keyboards",
                Description = "Computer keyboards",
                CreatedDate = new DateTime(2025, 1, 5)
            },
            new Category
            {
                Id = 6,
                Name = "Mice",
                Description = "Computer mice",
                CreatedDate = new DateTime(2025, 1, 6)
            },
            new Category
            {
                Id = 7,
                Name = "Headphones",
                Description = "Audio headphones",
                CreatedDate = new DateTime(2025, 1, 7)
            },
            new Category
            {
                Id = 8,
                Name = "Cameras",
                Description = "Digital cameras",
                CreatedDate = new DateTime(2025, 1, 8)
            },
            new Category
            {
                Id = 9,
                Name = "Printers",
                Description = "Office printers",
                CreatedDate = new DateTime(2025, 1, 9)
            },
            new Category
            {
                Id = 10,
                Name = "Accessories",
                Description = "Computer accessories",
                CreatedDate = new DateTime(2025, 1, 10)
            }
        };
    }
}

