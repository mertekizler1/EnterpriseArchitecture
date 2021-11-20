using EnterpriseArchitecture.Core.DataAccess;
using EnterpriseArchitecture.Entities.Concrete;
using EnterpriseArchitecture.Entities.DTOs;

namespace EnterpriseArchitecture.DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
        List<ProductDetailDTO> GetProductDetails();
    }
}