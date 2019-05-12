using Contracts;
using Entities;
using Entities.Models;

namespace Repository
{
    public class ProductVersionRepository : RepositoryBase<ProductVersion>, IProductVersionRepository
    {
        public ProductVersionRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}
