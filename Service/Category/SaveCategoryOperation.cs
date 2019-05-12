using Contracts;
using Domain;

namespace Service.Category
{
    class SaveCategoryOperation
    {
        private readonly IRepositoryWrapper _repo;

        public SaveCategoryOperation(IRepositoryWrapper repo)
        {
            _repo = repo;
        }

        public int Execute(CategoryModel category)
        {
            var newCategory = new Entities.Models.Category
            {
                CategoryName = category.CategoryName,
                ParentId = category.ParentId
            };
            _repo.Category.Create(newCategory);
            _repo.Save();
            return newCategory.Id;
        }
    }
}
