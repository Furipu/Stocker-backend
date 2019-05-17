
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities.Models
{
    public class Product
    {
        public int Id { get; set; }       
        [Required(ErrorMessage = "ProductName is required")]
        public string ProductName { get; set; }
        [Required(ErrorMessage = "QuantityInStock is required")]
        public int QuantityInStock { get; set; }
        public decimal LowestPrice { get; set; }
        public decimal LowestPricePerUnit { get; set; }
        public decimal LatestPrice { get; set; }
        public decimal latestPricePerUnit { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }
        public string LinkPdfManual { get; set; }
        
        public int? BrandId { get; set; }
        public Brand Brand { get; set; }
        public int? CategoryId { get; set; }
        public Category Category { get; set; }
        public int? LocationId { get; set; }
        public Location Location { get; set; }
        public int? StatusId { get; set; }
        public Status Status { get; set; }
        public int? QualityId { get; set; }
        public Quality Quality { get; set; }
        public int? MetricId { get; set; }
        public int? DefaultMetricId { get; set; }
        public Metric Metric { get; set; }

        public ICollection<ProductVersion> Products { get; set; }

    }
}
