using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities.Models
{ 
    public class Status
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string StatusName { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
