using Grocery.Core.Models;

namespace Grocery.Core.Interfaces.Services
{
    public interface IProductCategoryService
    {
        public List<Product> GetProductsNotInCategory(int categoryId);
        public string AddProductToCategory(int productId, int categoryId);
        public List<Product> SearchProducts(string searchTerm, int categoryId);
    }
}