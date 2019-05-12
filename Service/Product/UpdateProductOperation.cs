using Contracts;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service.Product
{
    public class UpdateProductOperation
    {
        private readonly IRepositoryWrapper _repo;

        public UpdateProductOperation(IRepositoryWrapper repo)
        {
            _repo = repo;
        }

        public void Execute(ProductModel product)
        {
            var productToUpdate = _repo.Product.FindByCondition(x => x.Id == product.Id).FirstOrDefault();

            productToUpdate.ProductName = product.ProductName;

            _repo.Product.Update(productToUpdate);
            _repo.Save();
        }
    }
}
