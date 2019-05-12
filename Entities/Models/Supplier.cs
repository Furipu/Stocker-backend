using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities.Models
{
    public class Supplier
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string SupplierName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string ContactPerson { get; set; }
        public int? AdressId { get; set; }

        public Adress Adress { get; set; }
        public ICollection<ProductVersion> ProductVersions { get; set; }
    }
}
