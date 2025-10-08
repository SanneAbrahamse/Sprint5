using Grocery.Core.Interfaces.Repositories;
using Grocery.Core.Interfaces.Services;
using Grocery.Core.Models;

namespace Grocery.Core.Services;

public class CategoryService : ICategoryService
{
    private readonly ICategoryRepository categoryRepo;

    public CategoryService(ICategoryRepository categoryRepo)
    {
        this.categoryRepo = categoryRepo;
    }

    public List<Category> GetAllCategories()
    {
        return categoryRepo.GetAll();
    }

    public Category? GetCategoryById(int id)
    {
        return categoryRepo.Get(id);
    }

    public Category? GetCategoryByName(string name)
    {
        return categoryRepo.Get(name);
    }
}