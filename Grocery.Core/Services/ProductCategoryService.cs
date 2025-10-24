using Grocery.Core.Interfaces.Repositories;
using Grocery.Core.Interfaces.Services;
using Grocery.Core.Models;

namespace Grocery.Core.Services
{
    public class ProductCategoryService : IProductCategoryService
    {
        private readonly IProductRepository productRepo;
        private readonly ICategoryRepository categoryRepo;
        private readonly IProductCategoryRepository productCategoryRepo;

        public ProductCategoryService(IProductRepository productRepo, ICategoryRepository categoryRepo, IProductCategoryRepository productCategoryRepo)
        {
            this.productRepo = productRepo;
            this.categoryRepo = categoryRepo;
            this.productCategoryRepo = productCategoryRepo;
        }

        // UC12/FR2 (1/2) - Ophalen producten
        public List<Product> GetProductsNotInCategory(int categoryId)
        {
            List<Product> result = new List<Product>();
            List<ProductCategory> categoryProducts = productCategoryRepo.GetByCategory(categoryId);
            foreach (Product product in productRepo.GetAll())
            {
                bool exists = false;
                foreach (var pc in categoryProducts)
                {
                    if (pc.ProductId == product.Id)
                    {
                        exists = true;
                        break;
                    }
                }
                if (!exists)
                {
                    result.Add(product);
                }
            }
            return result;
        }

        // UC12/FR2 (2/2) - Product toevoegen aan productcategorie
        public string AddProductToCategory(int productId, int categoryId)
        {
            Product? product = productRepo.Get(productId);
            Category? category = categoryRepo.Get(categoryId);
            if (product == null || category == null)
            {
                return "Product of categorie bestaat niet.";
            }
            ProductCategory? existing = productCategoryRepo.Get(productId, categoryId);

            if (existing != null)
            {
                return "Product zit al in deze categorie.";
            }
            ProductCategory newPc = new ProductCategory
            {
                ProductId = productId,
                CategoryId = categoryId
            };
            productCategoryRepo.Add(newPc);
            return "Product toegevoegd aan categorie.";
        }

        // UC12/FR3 - Zoeken producten in productenlijst
        public List<Product> SearchProducts(string searchTerm, int categoryId)
        {
            List<Product> result = new List<Product>();
            List<Product> productsNotInCategory = GetProductsNotInCategory(categoryId);

            foreach (Product product in productsNotInCategory)
            {
                if (product.Name.ToLower().Contains(searchTerm.ToLower()))
                {
                    result.Add(product);
                }
            }
            return result;
        }
    }
}