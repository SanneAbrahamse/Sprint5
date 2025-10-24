using Grocery.Core.Interfaces.Repositories;
using Grocery.Core.Interfaces.Services;
using Grocery.Core.Models;

namespace Grocery.Core.Services;

public class CategoryService : ICategoryService
{
    private readonly ICategoryRepository _categoryRepo;

    public CategoryService(ICategoryRepository categoryRepo)
    {
        this._categoryRepo = categoryRepo;
    }

    public List<Category> GetAllCategories()
    {
        return _categoryRepo.GetAll();
    }

    public Category? GetCategoryById(int id)
    {
        return _categoryRepo.Get(id);
    }

    public Category? GetCategoryByName(string name)
    {
        return _categoryRepo.Get(name);
    }

    public List<Category> GetAll()
    {
        throw new NotImplementedException();
    }

    public Category Add(Category item)
    {
        throw new NotImplementedException();
    }

    public Category? Delete(Category item)
    {
        throw new NotImplementedException();
    }

    public Category? Get(int id)
    {
        throw new NotImplementedException();
    }

    public Category? Update(Category item)
    {
        throw new NotImplementedException();
    }
}