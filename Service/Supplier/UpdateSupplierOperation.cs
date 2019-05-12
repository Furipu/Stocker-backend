using Contracts;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service.Supplier
{
    public class UpdateSupplierOperation
    {
        private readonly IRepositoryWrapper _repo;

        public UpdateSupplierOperation(IRepositoryWrapper repo)
        {
            _repo = repo;
        }

        public void Execute(SupplierModel supplier)
        {
            var supplierToUpdate = _repo.Supplier.GetAllWithInclude().FirstOrDefault(x => x.Id == supplier.Id);

            supplierToUpdate.SupplierName = supplier.SupplierName;
            supplierToUpdate.ContactPerson = supplier.ContactPerson;
            supplierToUpdate.Email = supplier.Email;
            supplierToUpdate.Phone = supplier.Phone;
            supplierToUpdate.Website = supplier.Website;
            supplierToUpdate.Adress.Street = supplier.Adress.Street;
            supplierToUpdate.Adress.StreetBus = supplier.Adress.StreetBus;
            supplierToUpdate.Adress.StreetNumber = supplier.Adress.StreetNumber;
            supplierToUpdate.Adress.PostCity.Id = supplier.Adress.PostCity.Id;
            supplierToUpdate.Adress.Country.Id = supplier.Adress.Country.Id;

            _repo.Supplier.Update(supplierToUpdate);
            _repo.Save();
        }
    }
}
