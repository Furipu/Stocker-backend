using Contracts;
using System.Collections.Generic;
using System.Linq;

namespace Service.Status
{
    class GetAllStatusOperation
    {
        private readonly IRepositoryWrapper _repo;
        public GetAllStatusOperation(IRepositoryWrapper repo)
        {
            _repo = repo;
        }
        public List<Domain.StatusModel> Execute()
        {
            var statuses = _repo.Status.FindAll().ToList();

            var result = new List<Domain.StatusModel>();

            foreach (var status in statuses)
            {
                result.Add(new Domain.StatusModel
                {
                    Id = status.Id,
                    StatusName = status.StatusName
                });
            }

            return result;
        }
    }
}
