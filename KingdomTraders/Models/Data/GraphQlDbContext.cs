using KingdomTraders.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace KingdomTraders.Models.Data;

public class GraphQlDbContext : DbContext
{
    public GraphQlDbContext(DbContextOptions<GraphQlDbContext> options) : base(options)
    {
        
    }
    
    public DbSet<Product> Products { get; set; }
}
