using Contracts;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service.Product
{
    public class UpdateProductOperation
    {
        private readonly IRepositoryWrapper _repo;

        public UpdateProductOperation(IRepositoryWrapper repo)
        {
            _repo = repo;
        }

        public void Execute(ProductModel product)
        {
            var productToUpdate = _repo.Product.FindByCondition(x => x.Id == product.Id).FirstOrDefault();

            productToUpdate.ProductName = product.ProductName;
            productToUpdate.Description = product.Description;
            productToUpdate.LinkPdfManual = product.LinkPdfManual;
            productToUpdate.Picture = product.Picture;
            productToUpdate.BrandId = product.BrandId;
            productToUpdate.MetricId = product.MetricId;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.LocationId = product.LocationId;
            productToUpdate.LowestPrice = product.LowestPrice;
            productToUpdate.LowestPricePerUnit = product.LowestPricePerUnit;
            productToUpdate.LatestPrice = product.LatestPrice;
            productToUpdate.latestPricePerUnit = product.LatestPricePerUnit;
            productToUpdate.QuantityInStock = product.QuantityInStock;
            productToUpdate.DefaultMetricId = product.DefaultMetricId;
            productToUpdate.QualityId = product.QualityId;
            productToUpdate.StatusId = product.StatusId;

            _repo.Product.Update(productToUpdate);
            _repo.Save();
        }
    }
}
