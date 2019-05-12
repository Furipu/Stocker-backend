using Contracts;
using System.Linq;

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

            var category = _repo.Category.FindByCondition(x => x.Id == id).FirstOrDefault();
            _repo.Category.Delete(category);
            _repo.Save();
        }
    }
}
