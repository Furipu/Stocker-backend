using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class LocationModel
    {
        public int Id { get; set; }
        public string LocationName { get; set; }
        public int? ParentId { get; set; }
        public List<LocationModel> Children { get; set; }

    }
}
