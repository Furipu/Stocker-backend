using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service.Product
{
    public class DeleteProductOperation
    {
        private readonly IRepositoryWrapper _repo;
        public DeleteProductOperation(IRepositoryWrapper repo)
        {
            _repo = repo;
        }

        public void Execute(int id)
        {

            var product = _repo.Product.FindByCondition(x => x.Id == id).FirstOrDefault();
            _repo.Product.Delete(product);
            _repo.Save();
        }
    }
}
