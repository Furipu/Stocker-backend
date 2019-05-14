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
            var location = _repo.Location.GetAllWithInclude().FirstOrDefault(x => x.Id == id);
            RemoveChildren(location.Id);
            _repo.Location.Delete(location);
            _repo.Save();
        }

        private void RemoveChildren(int id)
        {
            var children = _repo.Location.FindByCondition(x => x.ParentId == id).ToList();

            foreach (var child in children)
            {
                RemoveChildren(child.Id);
                _repo.Location.Delete(child);
            }
        }
    }
}
