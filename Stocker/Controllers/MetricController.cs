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
    public class MetricController : ControllerBase
    {
        private readonly IStockerService _service;

        public MetricController(IStockerService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAllMetrics()
        {
            var countries = _service.GetAllMetrics();
            return Ok(countries);
        }
        [HttpGet("{id}", Name = "MetricById")]
        public IActionResult GetMetricById(int id)
        {
            var metric = _service.GetMetricById(id);
            return Ok(metric);
        }

        [HttpPost]
        public IActionResult CreateMetric([FromBody]MetricModel metric)
        {
            var id = _service.CreateMetric(metric);
            return Ok(metric);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateMetric([FromBody]MetricModel metric)
        {
            _service.UpdateMetric(metric);
            return Ok(metric);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteMetric(int id)
        {
            _service.DeleteMetric(id);
            return NoContent();
        }
    }
}