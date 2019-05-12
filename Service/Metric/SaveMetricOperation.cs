using Contracts;
using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Metric
{
    public class SaveMetricOperation
    {
        private readonly IRepositoryWrapper _repo;

        public SaveMetricOperation(IRepositoryWrapper repo)
        {
            _repo = repo;
        }

        public int Execute(MetricModel metric)
        {
            var newMetric = new Entities.Models.Metric
            {
                MetricName = metric.MetricName
            };
            _repo.Metric.Create(newMetric);
            _repo.Save();
            return newMetric.Id;
        }
    }
}
