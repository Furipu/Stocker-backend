using Contracts;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service.Metric
{
    public class GetMetricByIdOperation
    {
        private readonly IRepositoryWrapper _repo;

        public GetMetricByIdOperation(IRepositoryWrapper repo)
        {
            _repo = repo;
        }

        public MetricModel Execute(int id)
        {
            var metric = _repo.Metric.FindByCondition(met => met.Id.Equals(id)).FirstOrDefault();

            return new MetricModel
            {
                Id = metric.Id,
                MetricName = metric.MetricName
            };
        }
    }
}
