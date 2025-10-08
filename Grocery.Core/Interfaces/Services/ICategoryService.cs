using Grocery.Core.Models;

namespace Grocery.Core.Interfaces.Services;

public interface ICategoryService
{
    List<Category> GetAllCategories();
    Category? GetCategoryById(int id);
    Category? GetCategoryByName(string name);
}