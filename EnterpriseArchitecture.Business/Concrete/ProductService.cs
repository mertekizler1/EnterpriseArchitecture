using EnterpriseArchitecture.Business.Abstract;
using EnterpriseArchitecture.Core.Utilities.Results.Common;
using EnterpriseArchitecture.DataAccess.Abstract;
using EnterpriseArchitecture.Entities.Concrete;
using EnterpriseArchitecture.Entities.DTOs;

namespace EnterpriseArchitecture.Business.Concrete
{
    public class ProductService : IProductService
    {
        IProductDal _productDal;

        public ProductService(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public IResult Add(Product product)
        {
            if (product != null)
            {
                _productDal.Create(product);

                return new Result(true, "Added");
            }
            else
            {
                return new Result(false, "Failed");
            }
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }

        public List<Product> GetByCategoryId(int id)
        {
            var response = _productDal.GetAll(x => x.CategoryId == id);

            return response;
        }

        public Product GetById(int productId)
        {
            var result = _productDal.Get(p => p.ProductId == productId);

            return result;
        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            return _productDal.GetAll(x => x.UnitPrice >= min && x.UnitPrice <= max);
        }

        public List<ProductDetailDTO> GetProductDetails()
        {
            var result = _productDal.GetProductDetails();

            return result;
        }
    }
}