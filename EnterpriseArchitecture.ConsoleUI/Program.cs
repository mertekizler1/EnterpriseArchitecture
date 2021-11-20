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