using KingdomTraders.Models.Domain;

namespace KingdomTraders.GraphQl;

public class Query
{
    public Product GetProduct() => new Product
    {
        Id = Guid.NewGuid(),
        Name = "Drawing Abc",
        Price = 25.5
    };
}
