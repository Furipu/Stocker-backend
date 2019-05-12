using Contracts;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service.Category
{
    class GetCategoryByIdOperation
    {
        private readonly IRepositoryWrapper _repo;

        public GetCategoryByIdOperation(IRepositoryWrapper repo)
        {
            _repo = repo;
        }

        public CategoryModel Execute(int id)
        {
            var category = _repo.Category.FindByCondition(co => co.Id.Equals(id)).FirstOrDefault();

            return new CategoryModel
            {
                Id = category.Id,
                CategoryName = category.CategoryName,
                ParentId = category.ParentId
            };
        }
    }
}
