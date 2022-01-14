using EnterpriseArchitecture.Business.Abstract;
using EnterpriseArchitecture.Business.Constants;
using EnterpriseArchitecture.Core.Utilities.Results;
using EnterpriseArchitecture.Core.Utilities.Results.Common;
using EnterpriseArchitecture.DataAccess.Abstract;
using EnterpriseArchitecture.Entities.Concrete;
using EnterpriseArchitecture.Entities.DTOs;
using Microsoft.Extensions.Logging;

namespace EnterpriseArchitecture.Business.Concrete
{
    public class ProductService : IProductService
    {
        IProductDal _productDal;
        private readonly ILogger _logger;
        private readonly ICategoryService _categoryService;

        public ProductService(IProductDal productDal, ILogger logger, ICategoryService categoryService)
        {
            productDal = productDal ?? throw new ArgumentNullException(nameof(productDal));
            categoryService = categoryService ?? throw new ArgumentNullException(nameof(categoryService));

            _categoryService = categoryService;
            _productDal = productDal;
            _logger = logger;
        }

        public IResult Add(Product product)
        {
            const string methodName = nameof(Add);

            _logger.LogTrace($"[{methodName}] Invoked.");

            _logger.LogDebug($"[{methodName}] Checking category Limit.");
            CheckCategoryLimit(product.CategoryId);

            _logger.LogDebug($"[{methodName}] Checking product name '{product.ProductName}'.");
            if (product.ProductName.Length > 2)
            {
                _logger.LogDebug($"[{methodName}] Creating product.");
                _productDal.Create(product);

                _logger.LogTrace($"[{methodName}] Returning result.");
                return new SuccessResult(Messages.ProductAdded);
            }

            _logger.LogTrace($"[{methodName}] Failed.");
            return new ErrorResult(Messages.ProductNameInvalid);
        }

        public IResult Delete(Product product)
        {
            const string methodName = nameof(Delete);

            _logger.LogTrace($"[{methodName}] Invoked.");

            if (product == null)
            {
                throw new ArgumentNullException(nameof(product));
            }

            _logger.LogDebug($"[{methodName}] Deleting product {{@product}}");
            _productDal.Delete(product);

            _logger.LogDebug($"[{methodName}] Returning result.");
            return new SuccessResult();
        }

        public IDataResult<List<Product>> GetAll()
        {
            const string methodName = nameof(GetAll);

            _logger.LogTrace($"[{methodName}] Invoked.");

            _logger.LogTrace($"[{methodName}] Checking maintenance time.");

            if (DateTime.Now.Hour == 22)
            {
                _logger.LogDebug($"[{methodName}] Error, You cannot trade until 23:00 because it is under maintenance.");
                return new ErrorDataResult<List<Product>>(Messages.MaintenanceTime);
            }

            _logger.LogDebug($"[{methodName}] Getting all products.");
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(), Messages.ProductsListed);
        }

        public IDataResult<List<Product>> GetByCategoryId(int id)
        {
            const string methodName = nameof(GetByCategoryId);

            _logger.LogTrace($"[{methodName}] Invoked.");

            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            _logger.LogDebug($"[{methodName}] Returning result.");
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(x => x.CategoryId == id));
        }

        public IDataResult<Product> GetById(int productId)
        {
            const string methodName = nameof(GetById);

            _logger.LogTrace($"[{methodName}] Invoked.");

            if (productId == null)
            {
                throw new ArgumentNullException(nameof(productId));
            }

            _logger.LogDebug($"[{methodName}] Returning result.");
            return new SuccessDataResult<Product>(_productDal.Get(p => p.ProductId == productId));
        }

        public IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max)
        {
            const string methodName = nameof(GetByUnitPrice);

            _logger.LogTrace($"[{methodName}] Invoked.");

            if (min == null || max == null)
            {
                throw new ArgumentNullException(nameof(min));
            }

            _logger.LogDebug($"[{methodName}] Returning result.");
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(x => x.UnitPrice >= min && x.UnitPrice <= max));
        }

        public IDataResult<List<ProductDetailDTO>> GetProductDetails()
        {
            const string methodName = nameof(GetProductDetails);

            _logger.LogTrace($"[{methodName}] Invoked.");

            _logger.LogDebug($"[{methodName}] Returning result.");
            return new SuccessDataResult<List<ProductDetailDTO>>(_productDal.GetProductDetails());
        }

        private IResult CheckCategoryLimit(int categoryId)
        {
            const string methodName = nameof(CheckCategoryLimit);

            _logger.LogTrace($"[{methodName}] Invoked.");

            var result = _productDal.GetAll(p => p.CategoryId == categoryId).Count();

            if (result >= 15)
            {
                return new ErrorResult("cannot add product.");
            }

            return new SuccessResult(Messages.ProductAdded);
        }
    }
}