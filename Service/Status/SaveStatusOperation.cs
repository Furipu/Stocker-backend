using Contracts;

namespace Service.Status
{
    class SaveStatusOperation
    {
        private readonly IRepositoryWrapper _repo;

        public SaveStatusOperation(IRepositoryWrapper repo)
        {
            _repo = repo;
        }

        public int Execute(Domain.StatusModel status)
        {
            var newStatus = new Entities.Models.Status
            {
                StatusName = status.StatusName
            };
            _repo.Status.Create(newStatus);
            _repo.Save();
            return newStatus.Id;
        }
    }
}
