using Contracts;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service.ProductVersion
{
    class SaveProductVersionOperation
    {
        private readonly IRepositoryWrapper _repo;
        public SaveProductVersionOperation(IRepositoryWrapper repo)
        {
            _repo = repo;
        }

        public int Execute(ProductVersionModel productVersionModel)
        {

            var newProductVersionModel = new Entities.Models.ProductVersion
            {
                DayOfPurchase = Convert.ToDateTime(productVersionModel.DayOfPurchase),
                SupplierId = productVersionModel.SupplierId,
                ExpirationDate = Convert.ToDateTime(productVersionModel.ExpirationDate),
                LinkScanTicket = productVersionModel.LinkScanTicket,
                Price = productVersionModel.Price,
                PricePerUnit = productVersionModel.PricePerUnit,
                MetricId = productVersionModel.MetricId,
                ProductId = productVersionModel.ProductId,
                QuantityInStock = productVersionModel.QuantityInStock,
                MetricQuantity = productVersionModel.MetricQuantity,
            };

            _repo.ProductVersion.Create(newProductVersionModel);
            _repo.Save();
            return newProductVersionModel.Id;

        }
    }
}
