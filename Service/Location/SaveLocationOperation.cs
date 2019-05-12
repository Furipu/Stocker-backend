using Contracts;
using Domain;

namespace Service.Location
{
    public class SaveLocationOperation
    {
        private readonly IRepositoryWrapper _repo;

        public SaveLocationOperation(IRepositoryWrapper repo)
        {
            _repo = repo;
        }

        public int Execute(LocationModel location)
        {
            var newLocation = new Entities.Models.Location
            {
                LocationName = location.LocationName,
                ParentId = location.ParentId
            };
            _repo.Location.Create(newLocation);
            _repo.Save();
            return newLocation.Id;
        }
    }
}
