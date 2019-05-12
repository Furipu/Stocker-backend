using Contracts;
using Domain;
using System.Linq;

namespace Service.Brand
{
    public class GetBrandByIdOperation
    {
        private readonly IRepositoryWrapper _repo;

        public GetBrandByIdOperation(IRepositoryWrapper repo)
        {
            _repo = repo;
        }

        public BrandModel Execute(int id)
        {
            var brand = _repo.Brand.GetAllWithInclude().FirstOrDefault(x => x.Id == id);

            return new BrandModel
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
                    StreetNumber = brand.Adress.StreetNumber
                }
            };
        }
    }
}
