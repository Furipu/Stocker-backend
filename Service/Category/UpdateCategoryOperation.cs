using Contracts;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service.Category
{
    public class UpdateCategoryOperation
    {
        private readonly IRepositoryWrapper _repo;

        public UpdateCategoryOperation(IRepositoryWrapper repo)
        {
            _repo = repo;
        }

        public void Execute(CategoryModel category)
        {
            var categoryToUpdate = _repo.Category.FindByCondition(x => x.Id == category.Id).FirstOrDefault();

            categoryToUpdate.CategoryName = category.CategoryName;

            _repo.Category.Update(categoryToUpdate);
            _repo.Save();
        }
    }
}
