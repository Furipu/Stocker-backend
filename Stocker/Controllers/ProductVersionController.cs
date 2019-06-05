using Contracts;
using Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Stocker.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class ProductVersionController : ControllerBase
    {
        private readonly IStockerService _service;

        public ProductVersionController(IStockerService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAllProductVersions()
        {
            var productVersions = _service.GetAllProductVersions();
            return Ok(productVersions);
        }
        [HttpGet("{id}", Name = "ProductVersionById")]
        public IActionResult GetProductVersionById(int id)
        {
            var productVersion = _service.GetProductVersionById(id);
            return Ok(productVersion);
        }
        [Route("[action]/{id}")]
        [HttpGet]
        public IActionResult GetProductsVersionsByProductId(int id)
        {
            var productVersions = _service.GetProductsVersionsByProductId(id);
            return Ok(productVersions);
        }

        [Route("[action]/{id}")]
        [HttpGet]
        public IActionResult  GetDefaultProductVersionByProductId(int id)
        {
            var productVersion = _service.GetDefaultProductVersionByProductId(id);
            return Ok(productVersion);
        }

        [HttpPost]
        public IActionResult CreateProductVersion([FromBody]ProductVersionModel productVersion)
        {
            var id = _service.CreateProductVersion(productVersion);
            return Ok(productVersion);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateProductVersion([FromBody]ProductVersionModel productVersion)
        {
            _service.UpdateProductVersion(productVersion);
            return Ok(productVersion);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteProductVersion(int id)
        {
            _service.DeleteProductVersion(id);
            return NoContent();
        }
    }
}