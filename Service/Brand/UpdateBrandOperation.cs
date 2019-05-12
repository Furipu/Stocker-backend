using Contracts;
using Domain;
using System.Linq;

namespace Service.Brand
{
    public class UpdateBrandOperation
    {
        private readonly IRepositoryWrapper _repo;

        public UpdateBrandOperation(IRepositoryWrapper repo)
        {
            _repo = repo;
        }

        public void Execute(BrandModel brand)
        {
            var brandToUpdate = _repo.Brand.GetAllWithInclude().FirstOrDefault(x => x.Id == brand.Id);

            brandToUpdate.BrandName = brand.BrandName;
            brandToUpdate.ContactPerson = brand.ContactPerson;
            brandToUpdate.Email = brand.Email;
            brandToUpdate.Phone = brand.Phone;
            brandToUpdate.WebSite = brand.WebSite;
            brandToUpdate.Adress.Street = brand.Adress.Street;
            brandToUpdate.Adress.StreetBus = brand.Adress.StreetBus;
            brandToUpdate.Adress.StreetNumber = brand.Adress.StreetNumber;
            brandToUpdate.Adress.PostCity.Id = brand.Adress.PostCity.Id;
            brandToUpdate.Adress.Country.Id = brand.Adress.Country.Id;

            _repo.Brand.Update(brandToUpdate);
            _repo.Save();
        }       
    }
}
