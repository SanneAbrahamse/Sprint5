using Grocery.App.ViewModels;
using Grocery.Core.Interfaces.Services;
using Grocery.Core.Models;

namespace Grocery.App.Views;

public partial class CategoriesView : ContentPage
{
    private readonly IProductCategoryService _productCategoryService;

    public CategoriesView(CategoriesViewModel viewModel, IProductCategoryService productCategoryService)
    {
        InitializeComponent();
        BindingContext = viewModel;
        _productCategoryService = productCategoryService;
    }

    private async void OnCategorySelected(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.FirstOrDefault() is Category selectedCategory)
        {
            var productCategoriesViewModel = new ProductCategoriesViewModel(_productCategoryService, selectedCategory);
            await Navigation.PushAsync(new ProductCategoriesView(productCategoriesViewModel));
            ((CollectionView)sender).SelectedItem = null;
        }
    }
}