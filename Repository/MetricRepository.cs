using Contracts;
using Entities;
using Entities.Models;

namespace Repository
{
    public class MetricRepository : RepositoryBase<Metric>, IMetricRepository
    {
        public MetricRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}
