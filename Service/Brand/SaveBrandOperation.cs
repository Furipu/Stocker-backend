using Contracts;
using Domain;
using Entities.Models;

namespace Service.Brand
{
    public class SaveBrandOperation
    {
        private readonly IRepositoryWrapper _repo;

        public SaveBrandOperation(IRepositoryWrapper repo)
        {
            _repo = repo;
        }

        public int Execute(BrandModel brand)
        {
           
            var newBrand = new Entities.Models.Brand
            {
                BrandName = brand.BrandName,
                ContactPerson = brand.ContactPerson,
                Email = brand.Email,
                Phone = brand.Phone,
                WebSite = brand.WebSite,
                Adress = new Adress()
            };

            if (brand.Adress != null)
            {
                newBrand.Adress.Street = brand.Adress.Street;
                newBrand.Adress.StreetNumber = brand.Adress.StreetNumber;
                newBrand.Adress.StreetBus = brand.Adress.StreetBus;
                newBrand.Adress.PostCityId = brand.Adress.PostCity.Id;
                newBrand.Adress.CountryId = brand.Adress.Country.Id;
            }

            _repo.Brand.Create(newBrand);
            _repo.Save();
            return newBrand.Id;
        }
    }
}
