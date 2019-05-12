using Contracts;
using Domain;
using System.Linq;

namespace Service.PostCity
{
    public class GetPostCityByIdOperation
    {
        private readonly IRepositoryWrapper _repo;

        public GetPostCityByIdOperation(IRepositoryWrapper repo)
        {
            _repo = repo;
        }

        public PostCityModel Execute(int id)
        {
            var postCity = _repo.PostCity.FindByCondition(co => co.Id.Equals(id)).FirstOrDefault();

            return new PostCityModel
            {
                Id = postCity.Id,
                City = postCity.City,
                PostCode = postCity.PostCode,
                Province = postCity.Province,
                SubMunicipality = postCity.SubMunicipality
            };
        }
    }
}
