using Grocery.Core.Interfaces.Repositories;
using Grocery.Core.Models;

namespace Grocery.Core.Data.Repositories;

public class CategoryRepository : ICategoryRepository
{
    private readonly List<Category> categoryList;

    public CategoryRepository()
    {
        categoryList = new List<Category> {
        new Category(1, "Bakkerij"),
        new Category(2, "Zuivel"),
        new Category(3, "Onbijtgranen")
        };
    }
    
    public Category? Get(int id)
    {
        Category? category = categoryList.FirstOrDefault(c => c.Id == id);
        return category;
    }
    
    public Category? Get(string name)
    {
        Category? category = categoryList.FirstOrDefault(c => c.Name == name);
        return category;
    }
    
    public List<Category> GetAll()
    {
        return categoryList;
    }

    public Category Add(Category item)
    {
        throw new NotImplementedException();
    }

    public Category? Delete(Category item)
    {
        throw new NotImplementedException();
    }

    public Category? Update(Category item)
    {
        throw new NotImplementedException();
    }
}