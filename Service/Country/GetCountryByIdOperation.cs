using Contracts;
using Domain;
using System.Linq;

namespace Service.Country
{
    public class GetCountryByIdOperation
    {
        private readonly IRepositoryWrapper _repo;

        public GetCountryByIdOperation(IRepositoryWrapper repo)
        {
            _repo = repo;
        }

        public CountryModel Execute(int id)
        {
            var country = _repo.Country.FindByCondition(co => co.Id.Equals(id)).FirstOrDefault();

            return new CountryModel
            {
                Id = country.Id,
                CountryName = country.CountryName
            };
        }
    }
}
