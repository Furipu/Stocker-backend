using Contracts;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service.Brand
{
    public class GetAllBrandOperation
    {
        private readonly IRepositoryWrapper _repo;
        public GetAllBrandOperation(IRepositoryWrapper repo)
        {
            _repo = repo;
        }
        public List<BrandModel> Execute()
        {
            var brands = _repo.Brand.GetAllWithInclude();

            var result = new List<BrandModel>();

            foreach (var brand in brands)
            {
                var newBrandModel = new BrandModel
                {
                    Id = brand.Id,
                    BrandName = brand.BrandName,
                    AdressId = brand.AdressId,
                    ContactPerson = brand.ContactPerson,
                    Email = brand.Email,
                    Phone = brand.Phone,
                    WebSite = brand.WebSite,
                    Adress = new AdressModel
                    {
                        Id = brand.Adress.Id,
                        Street = brand.Adress.Street,
                        StreetBus = brand.Adress.StreetBus,
                        StreetNumber = brand.Adress.StreetNumber,
                        PostCityId = brand.Adress.PostCityId,
                        CountryId = brand.Adress.CountryId,
                    }
                };
                if (brand.Adress.PostCity != null)
                {

                    newBrandModel.Adress.PostCity = new PostCityModel
                    {
                        PostCode = brand.Adress.PostCity?.PostCode,
                        City = brand.Adress.PostCity.City,
                        Province = brand.Adress.PostCity?.Province,
                        SubMunicipality = brand.Adress.PostCity?.SubMunicipality
                    };

                }
                if (brand.Adress.Country != null)
                {

                    newBrandModel.Adress.Country = new CountryModel
                    {
                        CountryName = brand.Adress.Country?.CountryName
                    };
                }
                result.Add(newBrandModel);
            }

            return result;
        }
    }
}
