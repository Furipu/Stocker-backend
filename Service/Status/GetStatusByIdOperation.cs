using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service.Status
{
    public class GetStatusByIdOperation
    {
        private readonly IRepositoryWrapper _repo;

        public GetStatusByIdOperation(IRepositoryWrapper repo)
        {
            _repo = repo;
        }

        public Domain.StatusModel Execute(int id)
        {
            var status =  _repo.Status.FindByCondition(st => st.Id.Equals(id)).FirstOrDefault();

            return new Domain.StatusModel
            {
                Id = status.Id,
                StatusName = status.StatusName
            };
        }
    }
}
