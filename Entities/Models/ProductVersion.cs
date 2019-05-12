using System;
using System.ComponentModel.DataAnnotations;

namespace Entities.Models
{
    public class ProductVersion
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "LowestPrice is required")]
        public decimal LowestPrice { get; set; }
        [Required(ErrorMessage = "LatestPrice is required")]
        public decimal LatestPrice { get; set; }
        [Required(ErrorMessage = "LowestPricePerUnit is required")]
        public decimal LowestPricePerUnit { get; set; }
        [Required(ErrorMessage = "LatestPricePerUnit is required")]
        public decimal LatestPricePerUnit { get; set; }
        [Required(ErrorMessage = "DayOfPurchase is required")]
        public DateTime DayOfPurchase { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public string LinkScanTicket { get; set; }

        public Product Product { get; set; }
        public Supplier Supplier { get; set; }
    }
}
