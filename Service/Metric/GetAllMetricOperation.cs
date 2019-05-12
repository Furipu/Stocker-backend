using Contracts;
using Domain;
using System.Collections.Generic;
using System.Linq;

namespace Service.Metric
{
    public class GetAllMetricOperation
    {
        private readonly IRepositoryWrapper _repo;
        public GetAllMetricOperation(IRepositoryWrapper repo)
        {
            _repo = repo;
        }
        public List<MetricModel> Execute()
        {
            var metrics = _repo.Metric.FindAll().ToList();

            var result = new List<MetricModel>();

            foreach (var metric in metrics)
            {
                result.Add(new MetricModel
                {
                    Id = metric.Id,
                    MetricName = metric.MetricName
                });
            }

            return result;
        }
    }
}
