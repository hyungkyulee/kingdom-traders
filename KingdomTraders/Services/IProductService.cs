using KingdomTraders.Models.Domain;

namespace KingdomTraders.Services;

public interface IProductService
{
    public Task<IEnumerable<Product>> GetAllProducts();
    public Task<Product> GetProductById(Guid id);
    public Task<Product> CreateProduct(Product product);
    public Task<Product> EditProduct(Product product);
    public Task DeleteProduct(Guid id);
}