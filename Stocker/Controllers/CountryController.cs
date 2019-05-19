using Contracts;
using Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Stocker.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly IStockerService _service;

        public CountryController(IStockerService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAllCountries()
        {
            var countries = _service.GetAllCountries();
            return Ok(countries);
        }
        [HttpGet("{id}", Name = "CountryById")]
        public IActionResult GetCountryById(int id)
        {
            var country = _service.GetCountryById(id);
            return Ok(country);
        }

        [HttpPost]
        public IActionResult CreateCountry([FromBody]CountryModel country)
        {
            var id = _service.CreateCountry(country);
            return Ok(country);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateCountry([FromBody]CountryModel country)
        {
            _service.UpdateCountry(country);
            return Ok(country);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteCountry(int id)
        {
            _service.DeleteCountry(id);
            return NoContent();
        }

    }
}