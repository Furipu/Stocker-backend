using Contracts;
using Entities;
using Microsoft.EntityFrameworkCore;
using Entities.Models;
using System.Collections.Generic;
using System.Linq;

namespace Repository
{
    public class BrandRepository : RepositoryBase<Brand>, IBrandRepository
    {
        private readonly RepositoryContext _repo;
        public BrandRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
            _repo = repositoryContext;
        }

        public IQueryable<Brand> GetAllWithInclude()
        {
            return _repo.Brands
                .Include(brand => brand.Adress).ThenInclude(brand => brand.PostCity)
                .Include(brand => brand.Adress).ThenInclude(brand => brand.Country);
        }
    }
}
