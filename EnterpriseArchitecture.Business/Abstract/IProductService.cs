using EnterpriseArchitecture.Core.Utilities.Results.Common;
using EnterpriseArchitecture.Entities.Concrete;
using EnterpriseArchitecture.Entities.DTOs;

namespace EnterpriseArchitecture.Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();

        List<Product> GetByCategoryId(int id);

        List<Product> GetByUnitPrice(decimal min, decimal max);

        List<ProductDetailDTO> GetProductDetails();

        IResult Add(Product product);

        Product GetById(int productId);
    }
}