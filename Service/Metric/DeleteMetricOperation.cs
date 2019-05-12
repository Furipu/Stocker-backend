using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service.Metric
{
    public class DeleteMetricOperation
    {
        private readonly IRepositoryWrapper _repo;
        public DeleteMetricOperation(IRepositoryWrapper repo)
        {
            _repo = repo;
        }

        public void Execute(int id)
        {

            var metric = _repo.Metric.FindByCondition(x => x.Id == id).FirstOrDefault();
            _repo.Metric.Delete(metric);
            _repo.Save();
        }
    }
}

