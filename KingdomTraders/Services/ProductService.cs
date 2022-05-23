using KingdomTraders.Models.Data;
using KingdomTraders.Models.Domain;

namespace KingdomTraders.Services;

class ProductService : IProductService
{
    private readonly GraphQlDbContext _dbContext;
    public ProductService(GraphQlDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public async Task<IEnumerable<Product>> GetAllProducts()
    {
        return _dbContext.Products;
    }
    public async Task<Product> GetProductById(Guid id)
    {
        return await _dbContext.Products.FindAsync(id);
    }
    public async Task<Product> CreateProduct(Product product)
    {
        await _dbContext.Products.AddAsync(product);
        await _dbContext.SaveChangesAsync();
        return product;
    }
    public async Task<Product> EditProduct(Product product)
    {
        var updatedProduct = await _dbContext.Products.FindAsync(product.Id);
        if (updatedProduct == null) return null;
        
        updatedProduct.Name = product.Name;
        updatedProduct.Price = product.Price;
        await _dbContext.SaveChangesAsync();
        return product;
    }
    public async Task DeleteProduct(Guid id)
    {
        var deletedProduct = await _dbContext.Products.FindAsync(id);
        if (deletedProduct == null) return;

        _dbContext.Products.Remove(deletedProduct);
        await _dbContext.SaveChangesAsync();
    }
}