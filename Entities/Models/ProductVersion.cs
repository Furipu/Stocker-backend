using System;
using System.ComponentModel.DataAnnotations;

namespace Entities.Models
{
    public class ProductVersion
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Quantity is required")]
        public int MetricQuantity { get; set; }
        public int QuantityInStock { get; set; }
        [Required(ErrorMessage = "LatestPrice is required")]
        public decimal Price { get; set; }
        [Required(ErrorMessage = "LatestPricePerUnit is required")]
        public decimal PricePerUnit { get; set; }
        [Required(ErrorMessage = "DayOfPurchase is required")]
        public DateTime DayOfPurchase { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public string LinkScanTicket { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int? SupplierId { get; set; }
        public Supplier Supplier { get; set; }
        public int MetricId { get; set; }
        public Metric Metric { get; set; }
    }
}
