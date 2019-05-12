using Contracts;
using System.Collections.Generic;
using System.Linq;

namespace Service.PostCity
{
    public class GetAllPostCityOperation
    {
        private readonly IRepositoryWrapper _repo;
        public GetAllPostCityOperation(IRepositoryWrapper repo)
        {
            _repo = repo;
        }
        public List<Domain.PostCityModel> Execute()
        {
            var postCityes = _repo.PostCity.FindAll().ToList();

            var result = new List<Domain.PostCityModel>();

            foreach (var postCity in postCityes)
            {
                result.Add(new Domain.PostCityModel
                {
                    Id = postCity.Id,
                    City = postCity.City,
                    PostCode = postCity.PostCode,
                    Province = postCity.Province,
                    SubMunicipality = postCity.SubMunicipality
                });
            }

            return result;
        }
    }
}
