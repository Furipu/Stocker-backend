using System.ComponentModel.DataAnnotations;

namespace Entities.Models
{
    public class PriceHistory
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Price is required")]
        public decimal Price { get; set; }
        [Required(ErrorMessage = "PricePerUnit is required")]
        public decimal PricePerUnit { get; set; }

    }
}
