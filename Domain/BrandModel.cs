using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class BrandModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string BrandName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string WebSite { get; set; }
        public string ContactPerson { get; set; }
        public int? AdressId { get; set; }
        public AdressModel Adress { get; set; }
    }

}
