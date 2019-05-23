using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service.ShopCart
{
    public class DeleteShopCartOperation
    {
        private readonly IRepositoryWrapper _repo;
        public DeleteShopCartOperation(IRepositoryWrapper repo)
        {
            _repo = repo;
        }

        public void Execute(int id)
        {

            var shopCart = _repo.ShopCart.FindByCondition(x => x.Id == id).FirstOrDefault();
            _repo.ShopCart.Delete(shopCart);
            _repo.Save();
        }
    }
}
