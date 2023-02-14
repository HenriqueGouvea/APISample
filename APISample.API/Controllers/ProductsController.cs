using API.ViewModel;
using APISample.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly ILogger<ProductsController> _logger;
        private readonly IProductRepository _productRepository;

        public ProductsController(ILogger<ProductsController> logger, IProductRepository productRepository)
        {
            _logger = logger;
            _productRepository = productRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductViewModel>>> Get()
        {
            return new OkObjectResult(await _productRepository.GetPublishedProducts());
        }
    }
}