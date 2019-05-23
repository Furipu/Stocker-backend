using Contracts;
using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.ShopCart
{
    public class SaveShopCartOperation
    {
        private readonly IRepositoryWrapper _repo;
        public SaveShopCartOperation(IRepositoryWrapper repo)
        {
            _repo = repo;
        }

        public int Execute(ShopCartModel shopCartModel)
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
    }
}
