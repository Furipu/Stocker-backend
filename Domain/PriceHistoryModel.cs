using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class PriceHistoryModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Price is required")]
        public decimal Price { get; set; }
        [Required(ErrorMessage = "PricePerUnit is required")]
        public decimal PricePerUnit { get; set; }

    }
}
