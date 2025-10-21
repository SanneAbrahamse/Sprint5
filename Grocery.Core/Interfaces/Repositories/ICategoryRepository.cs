using Grocery.Core.Models;

namespace Grocery.Core.Interfaces.Repositories;

public interface ICategoryRepository
{
    public Category? Get(int id);
    public Category? Get(string name);
    public List<Category> GetAll();
    public Category Add(Category item);

    public Category? Delete(Category item);

    public Category? Update(Category item);
}