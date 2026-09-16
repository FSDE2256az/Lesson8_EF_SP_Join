using Lesson8_EF_SP_Join.Models.Base;

namespace Lesson8_EF_SP_Join.Models;

public class Supplier : BaseEntity
{
    public string CompanyName { get; set; }
    public string? Address { get; set; }
    public string? Phone { get; set; }

    public virtual ICollection<Product> Products { get; set; }
}
