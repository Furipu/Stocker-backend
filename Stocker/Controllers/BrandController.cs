using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contracts;
using Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Stocker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : ControllerBase
    {
        private readonly IStockerService _service;

        public BrandController(IStockerService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAllBrands()
        {
            var brandes = _service.GetAllBrands();
            return Ok(brandes);
        }
        [HttpGet("{id}", Name = "BrandById")]
        public IActionResult GetBrandById(int id)
        {
            var brand = _service.GetBrandById(id);
            return Ok(brand);
        }

        [HttpPost]
        public IActionResult CreateBrand([FromBody]BrandModel brand)
        {
            var id = _service.CreateBrand(brand);
            return Ok(brand);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateBrand([FromBody]BrandModel brand)
        {
            _service.UpdateBrand(brand);
            return Ok(brand);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteBrand(int id)
        {
            _service.DeleteBrand(id);
            return NoContent();
        }
    }
}