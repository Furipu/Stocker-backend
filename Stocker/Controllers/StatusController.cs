using Contracts;
using Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace Stocker.Controllers
{

    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class StatusController : ControllerBase
    {
        private readonly IStockerService _service;

        public StatusController(IStockerService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAllStatuses()
        {
            var statuses = _service.GetAllStatuses();
            return Ok(statuses);
        }
        // GET api/status/5
        [HttpGet("{id}", Name = "StatusById")]
        public IActionResult GetStatusById(int id)
        {
            var status = _service.GetStatusById(id);
            return Ok(status);
        }

        [HttpPost]
        public IActionResult CreateStatus([FromBody]StatusModel status)
        {
            var id = _service.CreateStatus(status);
            return Ok(status);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateStatus([FromBody]StatusModel status)
        {
            _service.UpdateStatus(status);
            return Ok(status);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteStatus(int id)
        {
            _service.DeleteStatus(id);
            return NoContent();
        }
    }
}