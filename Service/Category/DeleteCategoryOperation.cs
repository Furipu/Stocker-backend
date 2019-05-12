using Contracts;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Service.Category
{
    public class DeleteCategoryOperation
    {
        private readonly IRepositoryWrapper _repo;
        public DeleteCategoryOperation(IRepositoryWrapper repo)
        {
            _repo = repo;
        }

        public void Execute(int id)
        {
            var category = _repo.Category.GetAllWithInclude().FirstOrDefault(x => x.Id == id);
             RemoveChildren(category.Id);
            _repo.Category.Delete(category);
            _repo.Save();
        }

        private void RemoveChildren(int id)
        {
            var children =  _repo.Category.FindByCondition(x => x.ParentId == id).ToList();

            foreach (var child in children)
            {
                 RemoveChildren(child.Id);
                _repo.Category.Delete(child);
            }
        }
    }
}
