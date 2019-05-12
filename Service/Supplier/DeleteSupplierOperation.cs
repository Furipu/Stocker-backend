using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service.Supplier
{
    public class DeleteSupplierOperation
    {
        private readonly IRepositoryWrapper _repo;
        public DeleteSupplierOperation(IRepositoryWrapper repo)
        {
            _repo = repo;
        }

        public void Execute(int id)
        {

            var supplier = _repo.Supplier.FindByCondition(x => x.Id == id).FirstOrDefault();
            var adress = _repo.Adress.FindByCondition(x => x.Id == supplier.AdressId).FirstOrDefault();
            _repo.Adress.Delete(adress);
            _repo.Supplier.Delete(supplier);
            _repo.Save();
        }
    }
}
