using Contracts;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service.ProductVersion
{
    class UpdateProductVersionOperation
    {
        private readonly IRepositoryWrapper _repo;

        public UpdateProductVersionOperation(IRepositoryWrapper repo)
        {
            _repo = repo;
        }

        public void Execute(ProductVersionModel productVersionModel)
        {
            var productVersionToUpdate = _repo.ProductVersion.FindByCondition(x => x.Id == productVersionModel.Id).FirstOrDefault();
              

            productVersionToUpdate.PricePerUnit = productVersionModel.PricePerUnit;
            productVersionToUpdate.MetricId = productVersionModel.MetricId;
            productVersionToUpdate.Price = productVersionModel.Price;
            productVersionToUpdate.ProductId = productVersionModel.ProductId;
            productVersionToUpdate.QuantityInStock = productVersionModel.QuantityInStock;
            productVersionToUpdate.MetricQuantity = productVersionModel.MetricQuantity;
            productVersionToUpdate.SupplierId = productVersionModel.SupplierId;
            productVersionToUpdate.DayOfPurchase = Convert.ToDateTime(productVersionModel.DayOfPurchase);
            productVersionToUpdate.ExpirationDate = Convert.ToDateTime(productVersionModel.ExpirationDate);
            productVersionToUpdate.LinkScanTicket = productVersionModel.LinkScanTicket;



            _repo.ProductVersion.Update(productVersionToUpdate);
            _repo.Save();
        }
    }
}
