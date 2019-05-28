using Contracts;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service.ShopCart
{
    public class SaveOrUpdateShopCartOperation
    {
        private readonly IRepositoryWrapper _repo;
        public SaveOrUpdateShopCartOperation(IRepositoryWrapper repo)
        {
            _repo = repo;
        }

        public int Execute(ShopCartModel shopCartModel)
        {
            var shopCart = _repo.ShopCart.FindByCondition(x => x.Id == shopCartModel.Id).FirstOrDefault();

            if (shopCart == null)
            {
                var newShopCart = new Entities.Models.ShopCart
                {
                    Quantity = shopCartModel.Quantity,
                    AdditionalInfo = shopCartModel.AdditionalInfo,
                    ProductId = shopCartModel.ProductId
                };

                _repo.ShopCart.Create(newShopCart);
                _repo.Save();
                return newShopCart.Id;
            }
            else
            {
                shopCart.Quantity = shopCartModel.Quantity;
                shopCart.AdditionalInfo = shopCartModel.AdditionalInfo;
                shopCart.ProductId = shopCartModel.ProductId;


                _repo.ShopCart.Update(shopCart);
                _repo.Save();
                return shopCart.Id;
            }            
        }
    }
}
