using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service.Country
{
    public class DeleteCountryOperation
    {
        private readonly IRepositoryWrapper _repo;
        public DeleteCountryOperation(IRepositoryWrapper repo)
        {
            _repo = repo;
        }

        public void Execute(int id)
        {

            var country = _repo.Country.FindByCondition(x => x.Id == id).FirstOrDefault();
            _repo.Country.Delete(country);
            _repo.Save();
        }
    }
}
