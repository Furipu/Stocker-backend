using Contracts;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service.Product
{
    public class GetAllProductOperation
    {
        private readonly IRepositoryWrapper _repo;
        public GetAllProductOperation(IRepositoryWrapper repo)
        {
            _repo = repo;
        }
        public List<ProductModel> Execute()
        {
            var products = _repo.Product.GetAllWithInclude();
            var productVersions = _repo.ProductVersion.FindAll().Where(pvs => pvs.QuantityInStock > 0);
            var result = new List<ProductModel>();

            foreach (var product in products)
            {
                result.Add(new ProductModel
                {
                    Id = product.Id,
                    ProductName = product.ProductName,
                    Description = product.Description,
                    LinkPdfManual = product.LinkPdfManual,
                    Picture = product.Picture,
                    LatestPrice = product.LatestPrice,
                    LatestPricePerUnit = product.latestPricePerUnit,
                    LowestPrice = product.LowestPrice,
                    LowestPricePerUnit = product.LowestPricePerUnit,
                    QuantityInStock = productVersions.Where(pvs => pvs.ProductId == product.Id).Sum(pvs => pvs.QuantityInStock),
                    BrandId = product.BrandId,
                    CategoryId = product.CategoryId,
                    LocationId = product.LocationId,
                    MetricId = product.MetricId,
                    QualityId = product.QualityId,
                    StatusId = product.StatusId,
                    Metric = new MetricModel
                    {
                        Id = product.Metric.Id,
                        MetricName = product.Metric.MetricName,
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

                });
            }

            return result;
        }
    }
}
