using Contracts;
using Domain;
using Service.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service.ShopCart
{
    public class GetAllShopCartOperation
    {
        private readonly IRepositoryWrapper _repo;
        public GetAllShopCartOperation(IRepositoryWrapper repo)
        {
            _repo = repo;
        }

        public List<ShopCartModel> Execute()
        {
            var shopCarts = _repo.ShopCart.FindAll();
            var products = new GetAllProductOperation(_repo).Execute();
            var result = new List<ShopCartModel>();
            

            foreach (var shopCart in shopCarts)
            {
                
                result.Add(new ShopCartModel
                {
                    Id = shopCart.Id,
                    AdditionalInfo = shopCart.AdditionalInfo,
                    ProductId = shopCart.ProductId,
                    Quantity = shopCart.Quantity,
                    Product = products.FirstOrDefault(x => x.Id == shopCart.ProductId)
                });
            }

            return result;
        }
    }
}
