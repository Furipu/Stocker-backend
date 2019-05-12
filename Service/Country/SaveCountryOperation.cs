using Contracts;
using Domain;

namespace Service.Country
{
    public class SaveCountryOperation
    {
        private readonly IRepositoryWrapper _repo;

        public SaveCountryOperation(IRepositoryWrapper repo)
        {
            _repo = repo;
        }

        public int Execute(CountryModel country)
        {
            var newCountry = new Entities.Models.Country
            {
                CountryName = country.CountryName
            };
            _repo.Country.Create(newCountry);
            _repo.Save();
            return newCountry.Id;
        }
    }
}
