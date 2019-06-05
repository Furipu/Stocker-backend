using Contracts;
using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Supplier
{
    public class GetAllSupplierOperation
    {
        private readonly IRepositoryWrapper _repo;
        public GetAllSupplierOperation(IRepositoryWrapper repo)
        {
            _repo = repo;
        }
        public List<SupplierModel> Execute()
        {
            var suppliers = _repo.Supplier.GetAllWithInclude();

            var result = new List<SupplierModel>();

            foreach (var supplier in suppliers)
            {
                var newSupplierModel = new SupplierModel
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
                        StreetNumber = supplier.Adress.StreetNumber,
                        PostCityId = supplier.Adress.PostCityId,
                        CountryId = supplier.Adress.CountryId,
                    }
                };
                if (supplier.Adress.PostCity != null)
                {

                    newSupplierModel.Adress.PostCity = new PostCityModel
                    {
                        PostCode = supplier.Adress.PostCity?.PostCode,
                        City = supplier.Adress.PostCity.City,
                        Province = supplier.Adress.PostCity?.Province,
                        SubMunicipality = supplier.Adress.PostCity?.SubMunicipality
                    };

                }
                if (supplier.Adress.Country != null)
                {

                    newSupplierModel.Adress.Country = new CountryModel
                    {
                        CountryName = supplier.Adress.Country?.CountryName
                    };
                }

                result.Add(newSupplierModel);
            }

            return result;
        }
    }
}
