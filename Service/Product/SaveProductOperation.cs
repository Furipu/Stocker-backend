using Contracts;
using Domain;

namespace Service.Product
{
    public class SaveProductOperation
    {
        private readonly IRepositoryWrapper _repo;

        public SaveProductOperation(IRepositoryWrapper repo)
        {
            _repo = repo;
        }

        public int Execute(ProductModel product)
        {
            var newProduct = new Entities.Models.Product
            {
                ProductName = product.ProductName,
                Description = product.Description,
                LinkPdfManual = product.LinkPdfManual,
                Picture = product.Picture,
                BrandId = product.BrandId,
                MetricId = product.MetricId,
                CategoryId = product.CategoryId,
                LocationId = product.LocationId,
                LowestPrice = product.LowestPrice,
                LowestPricePerUnit = product.LowestPricePerUnit,
                LatestPrice = product.LatestPrice,
                latestPricePerUnit = product.LatestPricePerUnit,
                QuantityInStock = product.QuantityInStock,
                DefaultMetricId = product.DefaultMetricId,
                QualityId = product.QualityId,
                StatusId = product.StatusId
            };
            _repo.Product.Create(newProduct);
            _repo.Save();
            return newProduct.Id;
        }
    }
}
