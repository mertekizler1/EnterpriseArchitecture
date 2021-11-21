using EnterpriseArchitecture.Business.Abstract;
using EnterpriseArchitecture.Business.Constants;
using EnterpriseArchitecture.Core.Utilities.Results;
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
            if (product.ProductName.Length > 2)
            {
                _productDal.Create(product);

                return new SuccessResult(Messages.ProductAdded);
            }

            return new ErrorResult(Messages.ProductNameInvalid);
        }

        public IDataResult<List<Product>> GetAll()
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<List<Product>>(Messages.MaintenanceTime);
            }

            return new SuccessDataResult<List<Product>>(_productDal.GetAll(), Messages.ProductsListed);
        }

        public IDataResult<List<Product>> GetByCategoryId(int id)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(x => x.CategoryId == id));
        }

        public IDataResult<Product> GetById(int productId)
        {
            return new SuccessDataResult<Product>(_productDal.Get(p => p.ProductId == productId));
        }

        public IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(x => x.UnitPrice >= min && x.UnitPrice <= max));
        }

        public IDataResult<List<ProductDetailDTO>> GetProductDetails()
        {
            return new SuccessDataResult<List<ProductDetailDTO>>(_productDal.GetProductDetails());
        }
    }
}