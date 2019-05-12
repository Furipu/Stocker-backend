using Contracts;
using Domain;
using System.Collections.Generic;
using System.Linq;

namespace Service.Location
{
    public class GetAllLocationOperation
    {

        private readonly IRepositoryWrapper _repo;
        public GetAllLocationOperation(IRepositoryWrapper repo)
        {
            _repo = repo;
        }
        public List<LocationModel> Execute()
        {
            var locations = _repo.Location.GetAllWithInclude();

            var result = new List<LocationModel>();

            var parentLocation = locations.Where(x => x.Parent == null).ToList();

            result = PopulateChildren(parentLocation);

            return result;
        }

        private List<LocationModel> PopulateChildren(List<Entities.Models.Location> locations)
        {
            var locationsList = new List<LocationModel>();
            if (locations.Any())
            {
                foreach (var location in locations)
                {
                    var locationModel = new LocationModel
                    {
                        Id = location.Id,
                        LocationName = location.LocationName,
                        ParentId = location.Parent?.Id,
                        Children = new List<LocationModel>()
                    };
                    if (location.Children != null)
                    {
                        locationModel.Children = PopulateChildren(location.Children.ToList());
                    }
                    locationsList.Add(locationModel);
                }
            }
            return locationsList;
        }
    }
}
