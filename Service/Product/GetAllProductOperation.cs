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
            var productVersions = _repo.ProductVersion.GetAllWithInclude().Where(pvs => pvs.QuantityInStock != 0);

            var result = new List<ProductModel>();

            foreach (var product in products)
            {
                var productVersionsForProduct = productVersions.Where(pvs => pvs.ProductId == product.Id).OrderByDescending(x => x.DayOfPurchase);

                result.Add(new ProductModel
                {
                    Id = product.Id,
                    ProductName = product.ProductName,
                    Description = product.Description,
                    LinkPdfManual = product.LinkPdfManual,
                    Picture = product.Picture,
                    ProductIdentifier = product.ProductIdentifier,
                    LatestPrice = productVersionsForProduct.FirstOrDefault().Price,
                    LatestPricePerUnit = productVersionsForProduct.FirstOrDefault().PricePerUnit,
                    LowestPrice = productVersionsForProduct.Min(x => x.Price),
                    LowestPricePerUnit = productVersionsForProduct.Min(x => x.PricePerUnit),
                    NumberInStock = productVersionsForProduct.Sum(x => x.QuantityInStock),
                    Metric = new MetricModel
                    {
                        Id = productVersionsForProduct.FirstOrDefault().Metric.Id,
                        MetricName  = productVersionsForProduct.FirstOrDefault().Metric.MetricName,
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
