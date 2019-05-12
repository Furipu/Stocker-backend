using Entities.Models;
using System.Linq;

namespace Contracts
{
    public interface IProductVersionRepository : IRepositoryBase<ProductVersion>
    {
        IQueryable<ProductVersion> GetAllWithInclude();
    }
}
