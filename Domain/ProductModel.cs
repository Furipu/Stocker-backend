using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class ProductModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "ProductIdentifier is required")]
        public string ProductIdentifier { get; set; }
        [Required(ErrorMessage = "ProductName is required")]
        public string ProductName { get; set; }
        [Required(ErrorMessage = "NumberInStock is required")]
        public int NumberInStock { get; set; }
        [Required(ErrorMessage = "LowestPrice is required")]
        public decimal LowestPrice { get; set; }
        [Required(ErrorMessage = "LatestPrice is required")]
        public decimal LatestPrice { get; set; }
        [Required(ErrorMessage = "LowestPricePerUnit is required")]
        public decimal LowestPricePerUnit { get; set; }
        [Required(ErrorMessage = "LatestPricePerUnit is required")]
        public decimal LatestPricePerUnit { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }
        public string LinkPdfManual { get; set; }
        public BrandModel Brand { get; set; }
        public QualityModel Quality { get; set; }
        public CategoryModel Category { get; set; }
        public LocationModel Location { get; set; }
        public StatusModel Status { get; set; }
        public MetricModel Metric { get; set; }

    }
}
