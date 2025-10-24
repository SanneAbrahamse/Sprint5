using Grocery.App.ViewModels;
using Grocery.Core.Interfaces.Services;
using Grocery.Core.Models;

namespace Grocery.App.Views;

public partial class CategoriesView : ContentPage
{
    public CategoriesView(CategoriesViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
    
    private async void OnCategorySelected(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.FirstOrDefault() is Category selectedCategory)
        {
            ((CollectionView)sender).SelectedItem = null; // reset selectie
            await Shell.Current.GoToAsync($"{nameof(ProductCategoriesView)}?categoryId={selectedCategory.Id}");
        }
    }
}