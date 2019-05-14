using Contracts;
using Entities;
using Microsoft.EntityFrameworkCore;
using Entities.Models;
using System.Collections.Generic;
using System.Linq;

namespace Repository
{
    public class LocationRepository : RepositoryBase<Location>, ILocationRepository
    {
        private readonly RepositoryContext _repo;
        public LocationRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
            _repo = repositoryContext;
        }

        public IQueryable<Location> GetAllWithInclude()
        {
            return _repo.Locations.Include(categorie => categorie.Children).AsNoTracking();
        }
    }
}
