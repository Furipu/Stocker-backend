using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service.ProductVersion
{
    class DeleteProductVersionOperation
    {
        private readonly IRepositoryWrapper _repo;
        public DeleteProductVersionOperation(IRepositoryWrapper repo)
        {
            _repo = repo;
        }

        public void Execute(int id)
        {

            var productVersion = _repo.ProductVersion.FindByCondition(x => x.Id == id).FirstOrDefault();
            _repo.ProductVersion.Delete(productVersion);
            _repo.Save();
        }
    }
}
