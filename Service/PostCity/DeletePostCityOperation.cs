using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service.PostCity
{
    public class DeletePostCityOperation
    {
        private readonly IRepositoryWrapper _repo;
        public DeletePostCityOperation(IRepositoryWrapper repo)
        {
            _repo = repo;
        }

        public void Execute(int id)
        {

            var postCity = _repo.PostCity.FindByCondition(x => x.Id == id).FirstOrDefault();
            _repo.PostCity.Delete(postCity);
            _repo.Save();
        }
    }
}
