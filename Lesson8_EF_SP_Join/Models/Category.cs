using Lesson8_EF_SP_Join.Models.Base;

namespace Lesson8_EF_SP_Join.Models;

public class Category : BaseEntity
{
    public string Name { get; set; }
    public string? Description { get; set; }

    public virtual ICollection<Product> Products { get; set; }
}
