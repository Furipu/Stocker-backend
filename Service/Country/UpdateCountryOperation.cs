using Contracts;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service.Country
{
    public class UpdateCountryOperation
    {
        private readonly IRepositoryWrapper _repo;

        public UpdateCountryOperation(IRepositoryWrapper repo)
        {
            _repo = repo;
        }

        public void Execute(CountryModel country)
        {
            var countryToUpdate = _repo.Country.FindByCondition(x => x.Id == country.Id).FirstOrDefault();

            countryToUpdate.CountryName = country.CountryName;

            _repo.Country.Update(countryToUpdate);
            _repo.Save();
        }
    }
}
