using Entities.Models;
using System.Collections.Generic;
using System.Linq;

namespace Contracts
{
    public interface ICategoryRepository : IRepositoryBase<Category>
    {
        IQueryable<Category> GetAllWithInclude();
    }
}
