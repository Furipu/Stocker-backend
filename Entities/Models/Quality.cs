using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities.Models
{
    public class Quality
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "QualityName is required")]
        public string QualityName { get; set; }

        public ICollection<Product> Products { get; set; }
        public ICollection<Brand> Brands { get; set; }
    }
}
