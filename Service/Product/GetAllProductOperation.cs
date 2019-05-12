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

            var result = new List<ProductModel>();

            foreach (var product in products)
            {
                result.Add(new ProductModel
                {
                    Id = product.Id,
                    ProductName = product.ProductName,
                    Description = product.Description,
                    LatestPrice = product.LatestPrice,
                    LatestPricePerUnit = product.LatestPricePerUnit,
                    LinkPdfManual = product.LinkPdfManual,
                    LowestPrice = product.LowestPrice,
                    LowestPricePerUnit = product.LowestPricePerUnit,
                    NumberInStock = product.NumberInStock,
                    Picture = product.Picture,
                    ProductIdentifier = product.ProductIdentifier,
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
