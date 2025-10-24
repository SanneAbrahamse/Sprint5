using Grocery.Core.Models;

namespace Grocery.Core.Interfaces.Services;

public interface ICategoryService
{
    List<Category> GetAllCategories();
    Category? GetCategoryById(int id);
    Category? GetCategoryByName(string name);
    
    public List<Category> GetAll();

    public Category Add(Category item);

    public Category? Delete(Category item);

    public Category? Get(int id);

    public Category? Update(Category item);
}