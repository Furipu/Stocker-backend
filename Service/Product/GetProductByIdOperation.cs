using Contracts;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service.Product
{
    public class GetProductByIdOperation
    {
        private readonly IRepositoryWrapper _repo;

        public GetProductByIdOperation(IRepositoryWrapper repo)
        {
            _repo = repo;
        }

        public ProductModel Execute(int id)
        {
            var product = _repo.Product.FindByCondition(co => co.Id.Equals(id)).FirstOrDefault();

            return new ProductModel
            {
                Id = product.Id,
                ProductName = product.ProductName,
                Description = product.Description,
                LinkPdfManual = product.LinkPdfManual,
                Picture = product.Picture,
                ProductIdentifier = product.ProductIdentifier
            };
        }
    }
}
