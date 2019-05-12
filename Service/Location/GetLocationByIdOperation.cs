using Contracts;
using Domain;
using System.Linq;

namespace Service.Location
{
    public class GetLocationByIdOperation
    {
        private readonly IRepositoryWrapper _repo;

        public GetLocationByIdOperation(IRepositoryWrapper repo)
        {
            _repo = repo;
        }

        public LocationModel Execute(int id)
        {
            var location = _repo.Location.FindByCondition(co => co.Id.Equals(id)).FirstOrDefault();

            return new LocationModel
            {
                Id = location.Id,
                LocationName = location.LocationName,
                ParentId = location.ParentId
            };
        }
    }
}
