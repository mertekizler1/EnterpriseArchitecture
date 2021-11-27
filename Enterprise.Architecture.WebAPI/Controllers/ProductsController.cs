using EnterpriseArchitecture.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Enterprise.Architecture.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public List<Product> Get()
        {
            return new List<Product>
            {
                new Product{ProductId = 1, ProductName = "elma"}
            };
        }
    }
}