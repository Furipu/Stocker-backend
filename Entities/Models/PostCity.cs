using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities.Models
{
    public class PostCity
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Postcode is required")]
        public string PostCode { get; set; }
        [Required(ErrorMessage = "City is required")]
        public string City { get; set; }
        public bool? SubMunicipality { get; set; }
        public string Province { get; set; }

        public ICollection<Adress> Adresses { get; set; }
    }
}
