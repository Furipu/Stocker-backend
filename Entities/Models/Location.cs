using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities.Models
{
    public class Location
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string LocationName { get; set; }
        public int? ParentId { get; set; }
        public Location Parent { get; set; }
        public ICollection<Location> Children { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
