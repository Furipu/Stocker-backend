using Contracts;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service.Country
{
    public class GetAllCountryOperation
    {
        private readonly IRepositoryWrapper _repo;
        public GetAllCountryOperation(IRepositoryWrapper repo)
        {
            _repo = repo;
        }
        public List<CountryModel> Execute()
        {
            var countries = _repo.Country.FindAll().ToList();

            var result = new List<CountryModel>();

            foreach (var country in countries)
            {
                result.Add(new CountryModel
                {
                    Id = country.Id,
                    CountryName = country.CountryName
                });
            }

            return result;
        }
    }
}
