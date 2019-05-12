using Contracts;
using Entities;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Repository
{
    public class ProductVersionRepository : RepositoryBase<ProductVersion>, IProductVersionRepository
    {
        private readonly RepositoryContext _repo;
        public ProductVersionRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
            _repo = repositoryContext;
        }

        public IQueryable<ProductVersion> GetAllWithInclude()
        {
            return _repo.ProductVersions.Include(pvs => pvs.Metric).AsNoTracking();
        }
    }
}
