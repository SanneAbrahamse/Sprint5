using System.Collections.ObjectModel;
using Grocery.Core.Interfaces.Services;
using Grocery.Core.Models;

namespace Grocery.App.ViewModels;

public class ProductCategoriesViewModel : BaseViewModel
{
    private readonly IProductCategoryService _productCategoryService;
  

    public ObservableCollection<Product> Products { get; set; }
    public string Title { get; set; }

    public ProductCategoriesViewModel(IProductCategoryService productCategoryService)
    {
        _productCategoryService = productCategoryService;
        
        Products = new ObservableCollection<Product>();
    }

    public List<Product> GetProducts(Category category)
    {
        Title = $"Producten in {category.Name}";
        foreach (var p in _productCategoryService.SearchProducts("", category.Id))
        {
            Products.Add(p);
        }
        return Products.ToList();
    }
}