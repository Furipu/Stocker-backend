using Contracts;
using Domain;
using Service.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service.ProductVersion
{
    class GetProductVersionByIdOperation
    {
        private readonly IRepositoryWrapper _repo;
        public GetProductVersionByIdOperation(IRepositoryWrapper repo)
        {
            _repo = repo;
        }

        public ProductVersionModel Execute(int id)
        {
            var productVersion = _repo.ProductVersion.FindByCondition(qua => qua.Id == id).FirstOrDefault();

            return new ProductVersionModel
            {
                Id = productVersion.Id,
                DayOfPurchase = productVersion.DayOfPurchase.ToString("yyyy-MM-dd"),
                ExpirationDate = productVersion.ExpirationDate?.ToString("dd-MM-yyyy"),
                LinkScanTicket = productVersion.LinkScanTicket,
                MetricId = productVersion.MetricId,
                ProductId = productVersion.ProductId,
                Product = new GetProductByIdOperation(_repo).Execute(id),
                PricePerUnit = productVersion.PricePerUnit,
                Price = productVersion.Price,
                SupplierId = productVersion.SupplierId
            };
        }
    }
}
