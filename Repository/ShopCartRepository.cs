using Contracts;
using Entities;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Repository
{
    public class ShopCartRepository : RepositoryBase<ShopCart>, IShopCartRepository
    {
        private readonly RepositoryContext _repo;
        public ShopCartRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
            _repo = repositoryContext;
        }

        public IQueryable<ShopCart> GetAllWithInclude()
        {
            return _repo.ShopCarts.Include(pvs => pvs.Product).AsNoTracking();
        }
    }
}
