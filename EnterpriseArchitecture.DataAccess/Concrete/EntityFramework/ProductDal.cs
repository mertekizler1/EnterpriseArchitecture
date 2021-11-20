using EnterpriseArchitecture.Core.DataAccess.EntityFramework;
using EnterpriseArchitecture.DataAccess.Abstract;
using EnterpriseArchitecture.DataAccess.Concrete.EntityFramework.Context;
using EnterpriseArchitecture.Entities.Concrete;
using EnterpriseArchitecture.Entities.DTOs;

namespace EnterpriseArchitecture.DataAccess.Concrete.EntityFramework
{
    public class ProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
    {
        public List<ProductDetailDTO> GetProductDetails()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var result = from p in context.Products
                             join c in context.Categories
                             on p.CategoryId equals c.CategoryId
                             select new ProductDetailDTO
                             {
                                 ProductId = p.ProductId,
                                 CategoryName = c.CategoryName,
                                 Description = c.Description,
                                 ProductName = p.ProductName,
                                 UnitPrice = p.UnitPrice,
                                 UnitsInStock = p.UnitsInStock
                             };

                return result.ToList();
            }
        }
    }
}