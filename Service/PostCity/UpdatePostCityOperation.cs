using Contracts;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service.PostCity
{
    class UpdatePostCityOperation
    {
        private readonly IRepositoryWrapper _repo;

        public UpdatePostCityOperation(IRepositoryWrapper repo)
        {
            _repo = repo;
        }

        public void Execute(PostCityModel postCity)
        {
            var postCityToUpdate = _repo.PostCity.FindByCondition(x => x.Id == postCity.Id).FirstOrDefault();

            postCityToUpdate.City = postCity.City;
            postCityToUpdate.PostCode = postCity.PostCode;
            postCityToUpdate.SubMunicipality = postCity.SubMunicipality;
            postCityToUpdate.Province = postCity.Province;

            _repo.PostCity.Update(postCityToUpdate);
            _repo.Save();
        }

    }
}
