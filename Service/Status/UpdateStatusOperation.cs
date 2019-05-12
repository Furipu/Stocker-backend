using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service.Status
{
    class UpdateStatusOperation
    {
        private readonly IRepositoryWrapper _repo;

        public UpdateStatusOperation(IRepositoryWrapper repo)
        {
            _repo = repo;
        }

        public void Execute(Domain.StatusModel status)
        {
            var statusToUpdate = _repo.Status.FindByCondition(x => x.Id == status.Id).FirstOrDefault();

            statusToUpdate.StatusName = status.StatusName;

            _repo.Status.Update(statusToUpdate);
            _repo.Save();
        }
    }
}
