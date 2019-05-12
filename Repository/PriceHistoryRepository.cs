using Contracts;
using Entities;
using Entities.Models;
namespace Repository
{
    public class PriceHistoryRepository : RepositoryBase<PriceHistory>, IPriceHistoryRepository
    {
        public PriceHistoryRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}
