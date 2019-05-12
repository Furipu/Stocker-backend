using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class SupplierModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string SupplierName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string ContactPerson { get; set; }
        public int? AdressId { get; set; }
        public AdressModel Adress { get; set; }
    }
}
