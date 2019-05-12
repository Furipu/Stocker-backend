using Contracts;
using Entities;
using Entities.Models;

namespace Repository
{
    public class QualityRepository : RepositoryBase<Quality>, IQualityRepository
    {
        public QualityRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}
