using System.Collections.ObjectModel;
using Grocery.Core.Interfaces.Services;
using Grocery.Core.Models;

namespace Grocery.App.ViewModels;

public class CategoriesViewModel : BaseViewModel
{
    private readonly ICategoryService _categoryService;
    public ObservableCollection<Category> Categories { get; set; }

    public CategoriesViewModel(ICategoryService categoryService)
    {
        _categoryService = categoryService;

        Categories = new ObservableCollection<Category>();

        // ObservableCollection met alle categorieën vullen
        foreach (Category c in _categoryService.GetAllCategories())
        {
            Categories.Add(c);
        }
        Console.WriteLine("CategoriesViewModel constructor called");
        foreach(var c in _categoryService.GetAllCategories()) 
            Console.WriteLine(c.Name);
    }
}