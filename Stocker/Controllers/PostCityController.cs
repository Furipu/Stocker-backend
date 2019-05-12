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
    public class PostCityController : ControllerBase
    {
        private readonly IStockerService _service;

        public PostCityController(IStockerService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAllPostCities()
        {
            var postCities = _service.GetAllPostCities();
            return Ok(postCities);
        }
        [HttpGet("{id}", Name = "PostCityById")]
        public IActionResult GetPostCityById(int id)
        {
            var postCity = _service.GetPostCityById(id);
            return Ok(postCity);
        }

        [HttpPost]
        public IActionResult CreatePostCity([FromBody]PostCityModel postCity)
        {
            var id = _service.CreatePostCity(postCity);
            return Ok(postCity);
        }

        [HttpPut("{id}")]
        public IActionResult UpdatePostCity([FromBody]PostCityModel postCity)
        {
            _service.UpdatePostCity(postCity);
            return Ok(postCity);
        }
        [HttpDelete("{id}")]
        public IActionResult DeletePostCity(int id)
        {
            _service.DeletePostCity(id);
            return NoContent();
        }
    }
}