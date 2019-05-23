using Contracts;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service.ShopCart
{
    public class UpdateShopCartOperation
    {
        private readonly IRepositoryWrapper _repo;

        public UpdateShopCartOperation(IRepositoryWrapper repo)
        {
            _repo = repo;
        }

        public void Execute(ShopCartModel shopCartModel)
        {
            var shopCartToUpdate = _repo.ShopCart.FindByCondition(x => x.Id == shopCartModel.Id).FirstOrDefault();

            shopCartToUpdate.Quantity = shopCartModel.Quantity;
            shopCartToUpdate.AdditionalInfo = shopCartModel.AdditionalInfo;
            shopCartToUpdate.ProductId = shopCartModel.ProductId;


            _repo.ShopCart.Update(shopCartToUpdate);
            _repo.Save();
        }
    }
}
