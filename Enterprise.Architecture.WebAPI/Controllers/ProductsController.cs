using EnterpriseArchitecture.Business.Abstract;
using EnterpriseArchitecture.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Enterprise.Architecture.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly ILogger _logger;

        public ProductsController(IProductService productService, ILogger logger)
        {
            productService = productService ?? throw new ArgumentNullException(nameof(productService));
            _productService = productService;
            _logger = logger;
        }

        [HttpGet]
        public List<Product> GetAll()
        {
            const string methodName = nameof(GetAll);

            _logger.LogTrace($"[{methodName}] Invoked.");

            _logger.LogDebug($"[{methodName}] Getting all products.");
            var products = _productService.GetAll();

            _logger.LogDebug($"[{methodName}] Returning result.");
            return products.Data;
        }
    }
}