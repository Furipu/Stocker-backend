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
                result.Add(new BrandModel
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
                        PostCity = new PostCityModel
                        {
                            Id = brand.Adress.PostCity.Id,
                            PostCode = brand.Adress.PostCity.PostCode,
                            City = brand.Adress.PostCity.City,
                            Province = brand.Adress.PostCity.Province,
                            SubMunicipality = brand.Adress.PostCity.SubMunicipality
                        },
                        Country = new CountryModel
                        {
                            Id = brand.Adress.Country.Id,
                            CountryName = brand.Adress.Country.CountryName
                        }
                    }
                });
            }

            return result;
        }
    }
}
