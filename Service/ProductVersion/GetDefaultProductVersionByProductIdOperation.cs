using Contracts;
using Domain;
using Service.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service.ProductVersion
{
    public class GetDefaultProductVersionByProductIdOperation
    {
        private readonly IRepositoryWrapper _repo;
        public GetDefaultProductVersionByProductIdOperation(IRepositoryWrapper repo)
        {
            _repo = repo;
        }

        public ProductVersionModel Execute(int id)
        {
            var lastSavedProductVersion = _repo.ProductVersion.FindByCondition(pve => pve.ProductId == id).FirstOrDefault();
            var products = new GetAllProductOperation(_repo).Execute();

            return new ProductVersionModel
            {

                DayOfPurchase = DateTime.Now.ToString("yyyy-MM-dd"),
                ExpirationDate = null,
                LinkScanTicket = null,
                ProductId = id,
                Product = products.FirstOrDefault(pro=> pro.Id == id),
                SupplierId = lastSavedProductVersion?.MetricId ?? 0,
                MetricId = lastSavedProductVersion?.MetricId ?? 0,
                
            };
        }
    }
}
