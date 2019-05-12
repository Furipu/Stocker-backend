using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service.Location
{
    public class DeleteLocationOperation
    {
        private readonly IRepositoryWrapper _repo;
        public DeleteLocationOperation(IRepositoryWrapper repo)
        {
            _repo = repo;
        }

        public void Execute(int id)
        {

            var location = _repo.Location.FindByCondition(x => x.Id == id).FirstOrDefault();
            _repo.Location.Delete(location);
            _repo.Save();
        }
    }
}
