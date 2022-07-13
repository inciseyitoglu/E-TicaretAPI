using E_TicaretAPI.Application.Abstracture;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_TicaretAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;
        public IActionResult GetProducts()
        {
            return Ok();
        }
    }
}
