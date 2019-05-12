using Contracts;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service.Metric
{
    public class UpdateMetricOperation
    {
        private readonly IRepositoryWrapper _repo;

        public UpdateMetricOperation(IRepositoryWrapper repo)
        {
            _repo = repo;
        }

        public void Execute(MetricModel metric)
        {
            var metricToUpdate = _repo.Metric.FindByCondition(x => x.Id == metric.Id).FirstOrDefault();

            metricToUpdate.MetricName = metric.MetricName;

            _repo.Metric.Update(metricToUpdate);
            _repo.Save();
        }
    }
}
