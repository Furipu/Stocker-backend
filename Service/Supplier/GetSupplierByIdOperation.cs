using Contracts;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service.Supplier
{
    public class GetSupplierByIdOperation
    {
        private readonly IRepositoryWrapper _repo;

        public GetSupplierByIdOperation(IRepositoryWrapper repo)
        {
            _repo = repo;
        }

        public SupplierModel Execute(int id)
        {
            var supplier = _repo.Supplier.GetAllWithInclude().FirstOrDefault(x => x.Id == id);

            return new SupplierModel
            {
                Id = supplier.Id,
                SupplierName = supplier.SupplierName,
                AdressId = supplier.AdressId,
                ContactPerson = supplier.ContactPerson,
                Email = supplier.Email,
                Phone = supplier.Phone,
                Website = supplier.Website,
                Adress = new AdressModel
                {
                    Id = supplier.Adress.Id,
                    Street = supplier.Adress.Street,
                    StreetBus = supplier.Adress.StreetBus,
                    StreetNumber = supplier.Adress.StreetNumber
                }
            };
        }
    }
}
