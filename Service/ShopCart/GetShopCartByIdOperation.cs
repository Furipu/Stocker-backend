using Contracts;
using Domain;
using Service.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service.ShopCart
{
    public class GetShopCartByIdOperation
    {
        private readonly IRepositoryWrapper _repo;
        public GetShopCartByIdOperation(IRepositoryWrapper repo)
        {
            _repo = repo;
        }

        public ShopCartModel Execute(int id)
        {
            var shopCart = _repo.ShopCart.FindByCondition(qua => qua.Id == id).FirstOrDefault();

            return new ShopCartModel
            {
                Id = shopCart.Id,
                Quantity = shopCart.Quantity,
                ProductId = shopCart.ProductId,
                AdditionalInfo = shopCart.AdditionalInfo,
                Product = new GetProductByIdOperation(_repo).Execute(shopCart.Id)
            };
        }
    }
}
