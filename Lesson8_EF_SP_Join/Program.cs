using Lesson8_EF_SP_Join.Contexts;

namespace Lesson8_EF_SP_Join;

public class Program
{
    static void Main(string[] args)
    {
        var dbContext = new AppDbContext();

        var prods = dbContext.Products;

        Console.WriteLine("Hello, World!");
    }
}
