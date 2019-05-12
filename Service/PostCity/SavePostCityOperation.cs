using Contracts;
using Domain;

namespace Service.PostCity
{
    public class SavePostCityOperation
    {
        private readonly IRepositoryWrapper _repo;

        public SavePostCityOperation(IRepositoryWrapper repo)
        {
            _repo = repo;
        }

        public int Execute(PostCityModel postCity)
        {
            var newPostCity = new Entities.Models.PostCity
            {
                City = postCity.City,
                PostCode = postCity.PostCode,
                SubMunicipality = postCity.SubMunicipality,
                Province = postCity.Province
            };
            _repo.PostCity.Create(newPostCity);
            _repo.Save();
            return newPostCity.Id;
        }
    }
}
