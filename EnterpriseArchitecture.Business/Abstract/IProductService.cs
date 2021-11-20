using EnterpriseArchitecture.Entities.Concrete;

namespace EnterpriseArchitecture.Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();

        List<Product> GetByCategoryId(int id);

        List<Product> GetByUnitPrice(decimal min, decimal max);
    }
}