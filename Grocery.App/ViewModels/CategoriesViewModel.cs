using System.Collections.ObjectModel;
using System.Windows.Input;
using Grocery.App.Views;
using Grocery.Core.Interfaces.Services;
using Grocery.Core.Models;

namespace Grocery.App.ViewModels;

public class CategoriesViewModel : BaseViewModel
{
    private readonly ICategoryService _categoryService;

    public ObservableCollection<Category> Categories { get; set; }
    public ICommand SelectCategoryCommand { get; }

    public CategoriesViewModel(ICategoryService categoryService)
    {
        _categoryService = categoryService;

        Categories = new ObservableCollection<Category>();

        // ObservableCollection met alle categorieën vullen
        foreach (Category c in _categoryService.GetAllCategories())
        {
            Categories.Add(c);
        }
    }
}