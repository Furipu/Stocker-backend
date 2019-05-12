using Entities.Models;
using System.Collections.Generic;
using System.Linq;

namespace Contracts
{
    public interface ILocationRepository : IRepositoryBase<Location>
    {
        IQueryable<Location> GetAllWithInclude();
    }
}
