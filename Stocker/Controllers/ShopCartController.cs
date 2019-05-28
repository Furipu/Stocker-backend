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
    public class ShopCartController : ControllerBase
    {
        private readonly IStockerService _service;

        public ShopCartController(IStockerService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAllShopCarts()
        {
            var shopCarts = _service.GetAllShopCarts();
            return Ok(shopCarts);
        }
        [HttpGet("{id}", Name = "ShopCartById")]
        public IActionResult GetShopCartById(int id)
        {
            var shopCart = _service.GetShopCartId(id);
            return Ok(shopCart);
        }
        [Route("[action]/{id}")]
        [HttpGet]
        public IActionResult GetShopCartByProductID(int id)
        {
            var shopCart = _service.GetOrCreateShopCartByProductID(id);
            return Ok(shopCart);
        }

        [HttpPost]
        public IActionResult CreateShopCart([FromBody]ShopCartModel shopCart)
        {
            var id = _service.CreateOrUpdateShopCart(shopCart);
            return Ok(shopCart);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateShopCart([FromBody]ShopCartModel shopCart)
        {
            _service.UpdateShopCart(shopCart);
            return Ok(shopCart);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteShopCart(int id)
        {
            _service.DeleteShopCart(id);
            return NoContent();
        }
    }
}