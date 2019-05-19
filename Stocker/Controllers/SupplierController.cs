using Contracts;
using Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Stocker.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class SupplierController : ControllerBase
    {
        private readonly IStockerService _service;

        public SupplierController(IStockerService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAllSuppliers()
        {
            var supplieres = _service.GetAllSuppliers();
            return Ok(supplieres);
        }
        [HttpGet("{id}", Name = "SupplierById")]
        public IActionResult GetsupplierById(int id)
        {
            var supplier = _service.GetSupplierById(id);
            return Ok(supplier);
        }

        [HttpPost]
        public IActionResult CreateSupplier([FromBody]SupplierModel supplier)
        {
            var id = _service.CreateSupplier(supplier);
            return Ok(supplier);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateSupplier([FromBody]SupplierModel supplier)
        {
            _service.UpdateSupplier(supplier);
            return Ok(supplier);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteSupplier(int id)
        {
            _service.DeleteSupplier(id);
            return NoContent();
        }
    }
}