using Contracts;
using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.ProductVersion
{
    class GetAllProductVersionOperation
    {
        private readonly IRepositoryWrapper _repo;
        public GetAllProductVersionOperation(IRepositoryWrapper repo)
        {
            _repo = repo;
        }

        public List<ProductVersionModel> Execute()
        {
            var productVersions = _repo.ProductVersion.FindAll();

            var result = new List<ProductVersionModel>();

            foreach (var productVersion in productVersions)
            {
                result.Add(new ProductVersionModel
                {
                    Id = productVersion.Id,
                    DayOfPurchase = productVersion.DayOfPurchase.ToString("yyyy-MM-dd"),
                    ExpirationDate = productVersion.ExpirationDate?.ToString("dd-MM-yyyy"),
                    Price = productVersion.Price,
                    PricePerUnit = productVersion.PricePerUnit,
                    LinkScanTicket = productVersion.LinkScanTicket,
                    MetricId = productVersion.MetricId,
                    ProductId = productVersion.ProductId,
                    SupplierId = productVersion.SupplierId                    
                });
            }

            return result;
        }
    }
}
