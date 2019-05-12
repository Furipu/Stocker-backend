using Contracts;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace Stocker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IStockerService _service;

        public ProductController(IStockerService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAllProducts()
        {
            var products = _service.GetAllProducts();
            return Ok(products);
        }
        [HttpGet("{id}", Name = "ProductById")]
        public IActionResult GetProductById(int id)
        {
            var product = _service.GetProductById(id);
            return Ok(product);
        }

        [HttpPost]
        public IActionResult CreateProduct([FromBody]ProductModel product)
        {
            var id = _service.CreateProduct(product);
            return Ok(product);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateProduct([FromBody]ProductModel product)
        {
            _service.UpdateProduct(product);
            return Ok(product);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            _service.DeleteProduct(id);
            return NoContent();
        }
    }
}