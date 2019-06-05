using Contracts;
using Domain;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Supplier
{
    public class SaveSupplierOperation
    {
        private readonly IRepositoryWrapper _repo;

        public SaveSupplierOperation(IRepositoryWrapper repo)
        {
            _repo = repo;
        }

        public int Execute(SupplierModel supplier)
        {

            var newSupplier = new Entities.Models.Supplier
            {
                SupplierName = supplier.SupplierName,
                ContactPerson = supplier.ContactPerson,
                Email = supplier.Email,
                Phone = supplier.Phone,
                Website = supplier.Website,
                Adress = new Adress()                
            };

            if (supplier.Adress != null)
            {
                newSupplier.Adress.Street = supplier.Adress.Street ?? "";
                newSupplier.Adress.StreetNumber = supplier.Adress.StreetNumber ?? 0;
                newSupplier.Adress.StreetBus = supplier.Adress.StreetBus ?? "";
                newSupplier.Adress.PostCityId = supplier.Adress.PostCity?.Id;
                newSupplier.Adress.CountryId = supplier.Adress.Country?.Id;
            }

            _repo.Supplier.Create(newSupplier);
            _repo.Save();
            return newSupplier.Id;
        }
    }
}
