using Contracts;
using Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Stocker.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IStockerService _service;

        public CategoryController(IStockerService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAllCategories()
        {
            var categories = _service.GetAllCategories();
            return Ok(categories);
        }
        [HttpGet("{id}", Name = "CategoryById")]
        public IActionResult GetCategoryById(int id)
        {
            var category = _service.GetCategoryById(id);
            return Ok(category);
        }

        [HttpPost]
        public IActionResult CreateCategory([FromBody]CategoryModel category)
        {
            var id = _service.CreateCategory(category);
            return Ok(category);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateCategory([FromBody]CategoryModel category)
        {
            _service.UpdateCategory(category);
            return Ok(category);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteCategory(int id)
        {
            _service.DeleteCategory(id);
            return NoContent();
        }
    }
}