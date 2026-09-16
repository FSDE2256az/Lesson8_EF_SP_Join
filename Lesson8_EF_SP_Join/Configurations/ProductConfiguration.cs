using Lesson8_EF_SP_Join.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lesson8_EF_SP_Join.Configurations;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder
            .Property(x => x.Name)
            .HasMaxLength(100)
            .IsRequired();

        builder
            .Property(x => x.Price)
            .IsRequired();

        builder
            .Property(x => x.UnitInStock)
            .IsRequired();

        builder
            .HasOne(x => x.Category)
            .WithMany(x => x.Products)
            .HasForeignKey(x => x.CategoryId)
            .OnDelete(DeleteBehavior.NoAction);

        builder
            .HasOne(x => x.Supplier)
            .WithMany(x => x.Products)
            .HasForeignKey(x => x.SupplierId)
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasData(GetProducts());
    }

    private List<Product> GetProducts()
    {
        return new List<Product>
        {
            new Product
            {
                Id = 1,
                Name = "Dell Inspiron 15",
                Price = 1450.00m,
                UnitInStock = 15,
                CategoryId = 1,
                SupplierId = 1,
                CreatedDate = new DateTime(2025, 2, 1)
            },

            new Product
            {
                Id = 2,
                Name = "HP Pavilion 15",
                Price = 1350.00m,
                UnitInStock = 12,
                CategoryId = 1,
                SupplierId = 2,
                CreatedDate = new DateTime(2025, 2, 2)
            },

            new Product
            {
                Id = 3,
                Name = "Samsung Galaxy S24",
                Price = 1850.00m,
                UnitInStock = 20,
                CategoryId = 2,
                SupplierId = 3,
                CreatedDate = new DateTime(2025, 2, 3)
            },

            new Product
            {
                Id = 4,
                Name = "iPhone 15",
                Price = 2100.00m,
                UnitInStock = 18,
                CategoryId = 2,
                SupplierId = 4,
                CreatedDate = new DateTime(2025, 2, 4)
            },

            new Product
            {
                Id = 5,
                Name = "iPad Air",
                Price = 1650.00m,
                UnitInStock = 10,
                CategoryId = 3,
                SupplierId = 5,
                CreatedDate = new DateTime(2025, 2, 5)
            },

            new Product
            {
                Id = 6,
                Name = "Samsung Galaxy Tab S9",
                Price = 1450.00m,
                UnitInStock = 14,
                CategoryId = 3,
                SupplierId = 6,
                CreatedDate = new DateTime(2025, 2, 6)
            },

            new Product
            {
                Id = 7,
                Name = "LG UltraGear 27",
                Price = 850.00m,
                UnitInStock = 9,
                CategoryId = 4,
                SupplierId = 7,
                CreatedDate = new DateTime(2025, 2, 7)
            },

            new Product
            {
                Id = 8,
                Name = "Samsung Odyssey G5",
                Price = 920.00m,
                UnitInStock = 11,
                CategoryId = 4,
                SupplierId = 8,
                CreatedDate = new DateTime(2025, 2, 8)
            },

            new Product
            {
                Id = 9,
                Name = "Logitech K380",
                Price = 75.00m,
                UnitInStock = 30,
                CategoryId = 5,
                SupplierId = 9,
                CreatedDate = new DateTime(2025, 2, 9)
            },

            new Product
            {
                Id = 10,
                Name = "Redragon K552",
                Price = 95.00m,
                UnitInStock = 25,
                CategoryId = 5,
                SupplierId = 10,
                CreatedDate = new DateTime(2025, 2, 10)
            },

            new Product
            {
                Id = 11,
                Name = "Logitech MX Master 3S",
                Price = 180.00m,
                UnitInStock = 17,
                CategoryId = 6,
                SupplierId = 1,
                CreatedDate = new DateTime(2025, 2, 11)
            },

            new Product
            {
                Id = 12,
                Name = "Razer DeathAdder V2",
                Price = 120.00m,
                UnitInStock = 22,
                CategoryId = 6,
                SupplierId = 2,
                CreatedDate = new DateTime(2025, 2, 12)
            },

            new Product
            {
                Id = 13,
                Name = "Sony WH-1000XM5",
                Price = 650.00m,
                UnitInStock = 13,
                CategoryId = 7,
                SupplierId = 3,
                CreatedDate = new DateTime(2025, 2, 13)
            },

            new Product
            {
                Id = 14,
                Name = "JBL Tune 770NC",
                Price = 220.00m,
                UnitInStock = 27,
                CategoryId = 7,
                SupplierId = 4,
                CreatedDate = new DateTime(2025, 2, 14)
            },

            new Product
            {
                Id = 15,
                Name = "Canon EOS 250D",
                Price = 1750.00m,
                UnitInStock = 7,
                CategoryId = 8,
                SupplierId = 5,
                CreatedDate = new DateTime(2025, 2, 15)
            },

            new Product
            {
                Id = 16,
                Name = "Nikon D7500",
                Price = 2300.00m,
                UnitInStock = 6,
                CategoryId = 8,
                SupplierId = 6,
                CreatedDate = new DateTime(2025, 2, 16)
            },

            new Product
            {
                Id = 17,
                Name = "HP LaserJet Pro",
                Price = 480.00m,
                UnitInStock = 8,
                CategoryId = 9,
                SupplierId = 7,
                CreatedDate = new DateTime(2025, 2, 17)
            },

            new Product
            {
                Id = 18,
                Name = "Canon Pixma G3410",
                Price = 390.00m,
                UnitInStock = 10,
                CategoryId = 9,
                SupplierId = 8,
                CreatedDate = new DateTime(2025, 2, 18)
            },

            new Product
            {
                Id = 19,
                Name = "Anker USB-C Hub",
                Price = 85.00m,
                UnitInStock = 35,
                CategoryId = 10,
                SupplierId = 9,
                CreatedDate = new DateTime(2025, 2, 19)
            },

            new Product
            {
                Id = 20,
                Name = "Baseus Laptop Stand",
                Price = 65.00m,
                UnitInStock = 40,
                CategoryId = 10,
                SupplierId = 10,
                CreatedDate = new DateTime(2025, 2, 20)
            }
        };
    }
}

