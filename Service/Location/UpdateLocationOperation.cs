using Contracts;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service.Location
{
    public class UpdateLocationOperation
    {
        private readonly IRepositoryWrapper _repo;

        public UpdateLocationOperation(IRepositoryWrapper repo)
        {
            _repo = repo;
        }

        public void Execute(LocationModel location)
        {
            var locationToUpdate = _repo.Location.FindByCondition(x => x.Id == location.Id).FirstOrDefault();

            locationToUpdate.LocationName = location.LocationName;

            _repo.Location.Update(locationToUpdate);
            _repo.Save();
        }
    }
}
