using Contracts;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace Stocker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QualityController : ControllerBase
    {
        private readonly IStockerService _service;

        public QualityController(IStockerService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAllQualities()
        {
            var qualityes = _service.GetAllQualities();
            return Ok(qualityes);
        }
        [HttpGet("{id}", Name = "QualityById")]
        public IActionResult GetQualityById(int id)
        {
            var quality = _service.GetQualityById(id);
            return Ok(quality);
        }

        [HttpPost]
        public IActionResult CreateQuality([FromBody]QualityModel quality)
        {
            var id = _service.CreateQuality(quality);
            return Ok(quality);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateQuality([FromBody]QualityModel quality)
        {
            _service.UpdateQuality(quality);
            return Ok(quality);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteQuality(int id)
        {
            _service.DeleteQuality(id);
            return NoContent();
        }
    }
}