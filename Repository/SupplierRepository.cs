using Contracts;
using Entities;
using Microsoft.EntityFrameworkCore;
using Entities.Models;
using System.Collections.Generic;
using System.Linq;

namespace Repository
{
    public class SupplierRepository : RepositoryBase<Supplier>, ISupplierRepository
    {
        private readonly RepositoryContext _repo;
        public SupplierRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
            _repo = repositoryContext;
        }

        public IQueryable<Supplier> GetAllWithInclude()
        {
            return _repo.Suppliers
                .Include(brand => brand.Adress).ThenInclude(brand => brand.PostCity)
                .Include(brand => brand.Adress).ThenInclude(brand => brand.Country);
                
        }
    }
}
