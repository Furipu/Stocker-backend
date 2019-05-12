using Contracts;
using Entities;
using Microsoft.EntityFrameworkCore;
using Entities.Models;
using System.Collections.Generic;
using System.Linq;

namespace Repository
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        private readonly RepositoryContext _repo;
        public ProductRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
            _repo = repositoryContext;
        }

        public IQueryable<Product> GetAllWithInclude()
        {
            return _repo.Products
                .Include(pro => pro.Brand)
                .Include(pro => pro.Category)
                .Include(pro => pro.Location)
                .Include(pro => pro.Status)
                .Include(pro => pro.Quality)
                .Include(pro => pro.Metric).AsNoTracking();
        }
    }
}
