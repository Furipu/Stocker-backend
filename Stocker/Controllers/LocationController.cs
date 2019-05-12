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
    public class LocationController : ControllerBase
    {
        private readonly IStockerService _service;

        public LocationController(IStockerService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAllLocations()
        {
            var locations = _service.GetAllLocations();
            return Ok(locations);
        }
        [HttpGet("{id}", Name = "LocationById")]
        public IActionResult GetLocationById(int id)
        {
            var location = _service.GetLocationById(id);
            return Ok(location);
        }

        [HttpPost]
        public IActionResult CreateLocation([FromBody]LocationModel location)
        {
            var id = _service.CreateLocation(location);
            return Ok(location);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateLocation([FromBody]LocationModel location)
        {
            _service.UpdateLocation(location);
            return Ok(location);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteLocation(int id)
        {
            _service.DeleteLocation(id);
            return NoContent();
        }
    }
}