using Contracts;
using Domain;
using Service.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service.ProductVersion
{
    class GetProductVersionsByProductIdOperation
    {
        private readonly IRepositoryWrapper _repo;
        public GetProductVersionsByProductIdOperation(IRepositoryWrapper repo)
        {
            _repo = repo;
        }

        public List<ProductVersionModel> Execute(int id)
        {
            var productVersions = _repo.ProductVersion.GetAllWithInclude().Where(qua => qua.ProductId == id &&
                                                                                qua.QuantityInStock > 0);
            var products = new GetAllProductOperation(_repo).Execute();

            var productVersionsModel = new List<ProductVersionModel>();

            foreach (var productVersion  in productVersions)
            {
                productVersionsModel.Add(new ProductVersionModel
                {
                    Id = productVersion.Id,
                    DayOfPurchase = productVersion.DayOfPurchase.ToString("dd-MM-yyyy"),
                    ExpirationDate = productVersion.ExpirationDate.Value.Date.ToString("dd-MM-yyyy"),
                    LinkScanTicket = productVersion.LinkScanTicket,
                    MetricId = productVersion.MetricId,
                    ProductId = productVersion.ProductId,
                    QuantityInStock = productVersion.QuantityInStock,
                    Product = products.FirstOrDefault(pro => pro.Id == id),
                    PricePerUnit = productVersion.PricePerUnit,
                    Price = productVersion.Price,
                    SupplierId = productVersion.SupplierId,
                    Supplier = new SupplierModel
                    {
                        Id = productVersion.Supplier.Id,
                        SupplierName = productVersion.Supplier.SupplierName,                        
                    }
                });
            }

            return productVersionsModel;
        }
    }
}
