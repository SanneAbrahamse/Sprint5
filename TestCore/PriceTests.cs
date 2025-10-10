using Grocery.Core.Data.Repositories;
using Grocery.Core.Models;

namespace TestCore;

public class PriceTests
{
    [SetUp]
    public void Setup()
    {
    }
    
    //FR2 - Actuele prijsinformatie
    [Test]
    public void ProductRepository_AllProducts_HaveValidPrice()
    {
        // Arrange
        ProductRepository repository = new ProductRepository();
    
        // Act
        List<Product> products = repository.GetAll();
    
        // Assert
        Assert.That(products, Is.All.Matches<Product>(p => p.Price > 0));
    }
    
    //FR1 - Basis functionaliteit
    [Test]
    public void Product_HasValidPrice_ReturnsCorrectPrice()
    {
        // Arrange
        Product product = new Product(1, "Melk", 300, new DateOnly(2025, 9, 25), 2.50m);
    
        // Act
        decimal price = product.Price;
    
        // Assert
        Assert.That(price, Is.EqualTo(2.50m));
    }
    
    //Edge case - Product zonder prijs krijgt standaardwaarde
    [Test]
    public void Product_WithoutPrice_HasDefaultValue()
    {
        // Arrange & Act
        Product product = new Product(1, "Test", 100);
    
        // Assert
        Assert.That(product.Price, Is.EqualTo(0m));
    }
}