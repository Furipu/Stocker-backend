using Contracts;
using Domain;

namespace Service.Product
{
    public class SaveProductOperation
    {
        private readonly IRepositoryWrapper _repo;

        public SaveProductOperation(IRepositoryWrapper repo)
        {
            _repo = repo;
        }

        public int Execute(ProductModel product)
        {
            var newProduct = new Entities.Models.Product
            {
                ProductName = product.ProductName,
                Description = product.Description,
                LatestPrice = product.LatestPrice,
                LatestPricePerUnit = product.LatestPricePerUnit,
                LinkPdfManual = product.LinkPdfManual,
                LowestPrice = product.LowestPrice,
                LowestPricePerUnit = product.LowestPricePerUnit,
                NumberInStock = product.NumberInStock,
                Picture = product.Picture,
                ProductIdentifier = product.ProductIdentifier
            };
            _repo.Product.Create(newProduct);
            _repo.Save();
            return newProduct.Id;
        }
    }
}
