using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities.Models
{
    public class Brand
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string BrandName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string WebSite { get; set; }
        public string ContactPerson { get; set; }
        public int? AdressId { get; set; }

        public Adress Adress { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
