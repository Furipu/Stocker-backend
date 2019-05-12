using Entities.Models;
using System.Collections.Generic;
using System.Linq;

namespace Contracts
{
    public interface ISupplierRepository : IRepositoryBase<Supplier>
    {
        IQueryable<Supplier> GetAllWithInclude();
    }
}
