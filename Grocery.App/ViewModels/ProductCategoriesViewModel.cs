using System.Collections.ObjectModel;
using Grocery.Core.Interfaces.Services;
using Grocery.Core.Models;

namespace Grocery.App.ViewModels;

public class ProductCategoriesViewModel : BaseViewModel
{
    private readonly IProductCategoryService _productCategoryService;
    private readonly Category _selectedCategory;

    public ObservableCollection<Product> Products { get; set; }
    public string Title { get; set; }

    public ProductCategoriesViewModel(IProductCategoryService productCategoryService, Category selectedCategory)
    {
        _productCategoryService = productCategoryService;
        _selectedCategory = selectedCategory;

        Title = $"Producten in {_selectedCategory.Name}";
        Products = new ObservableCollection<Product>();

        foreach (Product product in _productCategoryService.SearchProducts("", _selectedCategory.Id))
        {
            Products.Add(product);
        }
    }
}