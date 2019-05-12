using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities.Models
{
    public class Country
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string CountryName { get; set; }

        public ICollection<Adress> Adresses { get; set; }
        
    }
}
