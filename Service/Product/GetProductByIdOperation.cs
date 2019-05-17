using Contracts;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service.Product
{
    public class GetProductByIdOperation
    {
        private readonly IRepositoryWrapper _repo;

        public GetProductByIdOperation(IRepositoryWrapper repo)
        {
            _repo = repo;
        }

        public ProductModel Execute(int id)
        {
            var product = _repo.Product.GetAllWithInclude().FirstOrDefault(co => co.Id.Equals(id));

            return new ProductModel
            {
                Id = product.Id,
                ProductName = product.ProductName,
                Description = product.Description,
                LinkPdfManual = product.LinkPdfManual,
                Picture = product.Picture,
                MetricId = product.MetricId,
                StatusId = product.StatusId,
                QualityId = product.QualityId,
                LocationId = product.LocationId,
                DefaultMetricId = product.DefaultMetricId,
                BrandId = product.BrandId,
                CategoryId = product.CategoryId,
                LowestPrice = product.LowestPrice,
                LowestPricePerUnit = product.LowestPricePerUnit,
                LatestPrice = product.LatestPrice,
                LatestPricePerUnit = product.latestPricePerUnit,
                QuantityInStock = product.QuantityInStock,
                Metric = new MetricModel
                {
                    Id = product.Metric.Id,
                    MetricName = product.Metric.MetricName
                },
                Brand = new BrandModel
                {
                    Id = product.Brand.Id,
                    BrandName = product.Brand.BrandName
                },
                Category = new CategoryModel
                {
                    Id = product.Category.Id,
                    CategoryName = product.Category.CategoryName
                },
                Location = new LocationModel
                {
                    Id = product.Location.Id,
                    LocationName = product.Location.LocationName
                },
                Quality = new QualityModel
                {
                    Id = product.Quality.Id,
                    QualityName = product.Quality.QualityName
                },
                Status = new StatusModel
                {
                    Id = product.Status.Id,
                    StatusName = product.Status.StatusName
                }
            };
        }
    }
}
