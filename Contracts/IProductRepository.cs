using Entities.Models;
using System.Linq;

namespace Contracts
{
    public interface IProductRepository : IRepositoryBase<Product>
    {
        IQueryable<Product> GetAllWithInclude();
    }
}
