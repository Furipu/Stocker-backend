using Contracts;
using Domain;
using Service.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service.ShopCart
{
    public class GetShopCartByProductIdOperation
    {
        private readonly IRepositoryWrapper _repo;
        public GetShopCartByProductIdOperation(IRepositoryWrapper repo)
        {
            _repo = repo;
        }

        public ShopCartModel Execute(int id)
        {
            var shopCart = _repo.ShopCart.FindByCondition(qua => qua.ProductId == id).FirstOrDefault();

            if (shopCart == null)
            {
                throw new ArgumentNullException();
            }

            return new ShopCartModel
            {
                Id = shopCart.Id,
                Quantity = shopCart.Quantity,
                ProductId = shopCart.ProductId,
                AdditionalInfo = shopCart.AdditionalInfo,
                Product = new GetProductByIdOperation(_repo).Execute(shopCart.ProductId)
            };
        }
    }
}
