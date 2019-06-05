using System;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class ProductVersionModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "LatestPrice is required")]
        public decimal Price { get; set; }
        [Required(ErrorMessage = "LatestPricePerUnit is required")]
        public decimal PricePerUnit { get; set; }
        [Required(ErrorMessage = "DayOfPurchase is required")]
        public string DayOfPurchase { get; set; }
        public string ExpirationDate { get; set; }
        public string LinkScanTicket { get; set; }        
        public int MetricQuantity { get; set; }
        public int QuantityInStock { get; set; }

        public int ProductId { get; set; }
        public ProductModel Product { get; set; }
        public int? SupplierId { get; set; }
        public SupplierModel Supplier { get; set; }
        public int MetricId { get; set; }
        public MetricModel Metric { get; set; }
    }

}

