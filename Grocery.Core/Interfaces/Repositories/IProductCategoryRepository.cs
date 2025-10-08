using Grocery.Core.Models;

namespace Grocery.Core.Interfaces.Repositories;

public interface IProductCategoryRepository
{
    public ProductCategory? Get(int productId, int categoryId);
    public List<ProductCategory> GetByCategory(int categoryId);
    public void Add(ProductCategory productCategory);
}