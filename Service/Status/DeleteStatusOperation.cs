using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service.Status
{
  
    class DeleteStatusOperation
    {
        private readonly IRepositoryWrapper _repo;
        public DeleteStatusOperation(IRepositoryWrapper repo)
        {
            _repo = repo;
        }

        public void Execute(int id)
        {
            var status = _repo.Status.FindByCondition(x => x.Id == id).FirstOrDefault();
            _repo.Status.Delete(status);
            _repo.Save();
        }
    }
}
