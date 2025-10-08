using Grocery.Core.Interfaces.Repositories;
using Grocery.Core.Models;

namespace Grocery.Core.Data.Repositories;

public class ProductCategoryRepository : IProductCategoryRepository
{
    private readonly List<ProductCategory> productCategories = new();

    public ProductCategory? Get(int productId, int categoryId)
    {
        ProductCategory? productCategory = productCategories.FirstOrDefault(pc => pc.ProductId == productId && pc.CategoryId == categoryId);
        return productCategory;
    }

    public void Add(ProductCategory productCategory)
    {
        foreach (var pc in productCategories)
        {
            if (pc.ProductId == productCategory.ProductId && pc.CategoryId == productCategory.CategoryId)
            {
                return;
            }
        }
        productCategories.Add(productCategory);
    }

    public List<ProductCategory> GetAll()
    {
        return productCategories;
    }

    public List<ProductCategory> GetByCategory(int categoryId)
    {
        List<ProductCategory> result = new List<ProductCategory>();

        foreach (var pc in productCategories)
        {
            if (pc.CategoryId == categoryId)
            {
                result.Add(pc);
            }
        }
        return result;
    }
}