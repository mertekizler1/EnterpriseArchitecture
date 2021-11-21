using EnterpriseArchitecture.Core.Utilities.Results.Common;
using EnterpriseArchitecture.Entities.Concrete;
using EnterpriseArchitecture.Entities.DTOs;

namespace EnterpriseArchitecture.Business.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetAll();

        IDataResult<List<Product>> GetByCategoryId(int id);

        IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max);

        IDataResult<List<ProductDetailDTO>> GetProductDetails();

        IResult Add(Product product);

        IDataResult<Product> GetById(int productId);
    }
}