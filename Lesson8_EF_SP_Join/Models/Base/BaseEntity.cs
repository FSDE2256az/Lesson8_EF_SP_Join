namespace Lesson8_EF_SP_Join.Models.Base;

public abstract class BaseEntity 
{
    public int Id { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime? ModifierDate { get; set; }
}

