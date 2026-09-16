using Lesson8_EF_SP_Join.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lesson8_EF_SP_Join.Configurations;

public class SupplierConfiguration : IEntityTypeConfiguration<Supplier>
{
    public void Configure(EntityTypeBuilder<Supplier> builder)
    {
        builder
            .Property(x => x.CompanyName)
            .HasMaxLength(100)
            .IsRequired();

        builder
            .Property(x => x.Address)
            .HasMaxLength(150)
            .IsRequired(false);

        builder
            .Property(x => x.Phone)
            .HasMaxLength(20)
            .IsRequired(false);

        builder.HasData(GetSuppliers());
    }

    private List<Supplier> GetSuppliers()
    {
        return new List<Supplier>
        {
            new Supplier
            {
                Id = 1,
                CompanyName = "TechWorld LLC",
                Address = "Baku, Nizami Street 10",
                Phone = "+994501112233",
                CreatedDate = new DateTime(2025, 1, 1)
            },
            new Supplier
            {
                Id = 2,
                CompanyName = "Global Electronics",
                Address = "Baku, Tbilisi Avenue 25",
                Phone = "+994502223344",
                CreatedDate = new DateTime(2025, 1, 2)
            },
            new Supplier
            {
                Id = 3,
                CompanyName = "Smart Solutions",
                Address = "Baku, Yasamal District 15",
                Phone = "+994503334455",
                CreatedDate = new DateTime(2025, 1, 3)
            },
            new Supplier
            {
                Id = 4,
                CompanyName = "Digital Store",
                Address = "Baku, Narimanov 30",
                Phone = "+994504445566",
                CreatedDate = new DateTime(2025, 1, 4)
            },
            new Supplier
            {
                Id = 5,
                CompanyName = "Future Tech",
                Address = "Baku, Khatai 12",
                Phone = "+994505556677",
                CreatedDate = new DateTime(2025, 1, 5)
            },
            new Supplier
            {
                Id = 6,
                CompanyName = "Electro Market",
                Address = "Baku, Genclik 18",
                Phone = "+994506667788",
                CreatedDate = new DateTime(2025, 1, 6)
            },
            new Supplier
            {
                Id = 7,
                CompanyName = "Max Electronics",
                Address = "Baku, Sahil 22",
                Phone = "+994507778899",
                CreatedDate = new DateTime(2025, 1, 7)
            },
            new Supplier
            {
                Id = 8,
                CompanyName = "Azerbaijan Tech",
                Address = "Baku, 28 May 14",
                Phone = "+994508889900",
                CreatedDate = new DateTime(2025, 1, 8)
            },
            new Supplier
            {
                Id = 9,
                CompanyName = "Next Generation",
                Address = "Baku, Ahmadli 40",
                Phone = "+994509990011",
                CreatedDate = new DateTime(2025, 1, 9)
            },
            new Supplier
            {
                Id = 10,
                CompanyName = "Prime Suppliers",
                Address = "Baku, Badamdar 8",
                Phone = "+994510001122",
                CreatedDate = new DateTime(2025, 1, 10)
            }
        };
    }
}
