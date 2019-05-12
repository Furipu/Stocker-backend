using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class PostCityModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Postcode is required")]
        public string PostCode { get; set; }
        [Required(ErrorMessage = "City is required")]
        public string City { get; set; }
        public bool? SubMunicipality { get; set; }
        public string Province { get; set; }

    }
}
