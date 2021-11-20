// See https://aka.ms/new-console-template for more information
using EnterpriseArchitecture.Business.Abstract;
using EnterpriseArchitecture.Business.Concrete;
using EnterpriseArchitecture.DataAccess.Concrete.EntityFramework;

//Console.WriteLine("Hello, World!");

IProductService productService = new ProductService(new ProductDal());

Console.WriteLine("----------------------------");

Console.WriteLine("[Get All Invoked]");

Console.WriteLine("----------------------------");

foreach (var product in productService.GetAll())
{
    Console.WriteLine(product.ProductName);
}

Console.WriteLine("----------------------------");

Console.WriteLine("[Get By Category Id Invoked]");

Console.WriteLine("----------------------------");


foreach (var product in productService.GetByCategoryId(5))
{
    Console.WriteLine(product.ProductName);
}

Console.WriteLine("----------------------------");

Console.WriteLine("[Get By Unit Price Invoked]");

Console.WriteLine("----------------------------");

foreach (var product in productService.GetByUnitPrice(20,100))
{
    Console.WriteLine(product.ProductName);
}

Console.WriteLine("----------------------------");

Console.WriteLine("[Get Product Details Invoked]");

Console.WriteLine("----------------------------");

foreach (var product in productService.GetProductDetails())
{
    Console.WriteLine($"Product: {product.ProductName} // Category: {product.CategoryName} // " +
        $"Description: {product.Description} // Unit Price: {product.UnitPrice} // Units In Stock: {product.UnitsInStock}");
}


Console.WriteLine("----------------------------");

Console.WriteLine("[Get All Category Invoked]");

Console.WriteLine("----------------------------");

ICategoryService categoryService = new CategoryService(new CategoryDal());

foreach (var category in categoryService.GetAll())
{
    Console.WriteLine(category.CategoryName);
}