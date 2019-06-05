using Contracts;
using Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Stocker.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IStockerService _service;

        public UserController(IStockerService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllUsers()
        {
            var userModels = await _service.GetAllUsers();
            return Ok(userModels);
        }

        [HttpGet("{id}", Name = "UserById")]
        public async Task<IActionResult> GetUserById(string id)
        {
            var status = await _service.GetUserById(id);
            return Ok(status);
        }

        [HttpPost]
        public IActionResult CreateUser([FromBody]UserModel status)
        {
            _service.CreateUser(status);
            return NoContent();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateUser([FromBody]UserModel status)
        {
            _service.UpdateUser(status);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteUser(string id)
        {
            _service.DeleteUser(id);
            return NoContent();
        }
        [Route("[action]")]
        [HttpGet]
        public async Task<IActionResult> GetAllRoles()
        {
            var roles = await _service.GetAllRoles();
            return Ok(roles);
        }

    }
}