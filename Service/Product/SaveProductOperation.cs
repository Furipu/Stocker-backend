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
                LinkPdfManual = product.LinkPdfManual,
                Picture = product.Picture,
                ProductIdentifier = product.ProductIdentifier
            };
            _repo.Product.Create(newProduct);
            _repo.Save();
            return newProduct.Id;
        }
    }
}
