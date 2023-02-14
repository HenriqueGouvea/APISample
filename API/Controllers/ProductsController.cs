using API.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly ILogger<ProductsController> _logger;

        public ProductsController(ILogger<ProductsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductViewModel>>> Get()
        {
            return new OkObjectResult(new List<ProductViewModel> { new ProductViewModel { Id = "1000", Name = "Keyboard", Price = "50€", Available = true } });
        }
    }
}