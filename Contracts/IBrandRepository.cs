using Entities.Models;
using System.Collections.Generic;
using System.Linq;

namespace Contracts
{
    public interface IBrandRepository : IRepositoryBase<Brand>
    {
        IQueryable<Brand> GetAllWithInclude();
    }
}
