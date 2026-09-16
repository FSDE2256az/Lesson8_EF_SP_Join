using Lesson8_EF_SP_Join.Models.Base;

namespace Lesson8_EF_SP_Join.Models;

public class Product : BaseEntity
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int UnitInStock { get; set; }


    public int CategoryId { get; set; }
    public int SupplierId { get; set; }

    public Category Category { get; set; }
    public Supplier Supplier { get; set; }
}
