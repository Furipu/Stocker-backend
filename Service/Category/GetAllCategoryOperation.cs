using Contracts;
using Domain;
using System.Collections.Generic;
using System.Linq;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Service.Category
{
    public class GetAllCategoryOperation
    {

        private readonly IRepositoryWrapper _repo;
        public GetAllCategoryOperation(IRepositoryWrapper repo)
        {
            _repo = repo;
        }
        public List<CategoryModel> Execute()
        {
            var categories = _repo.Category.GetAllWithInclude().ToList();

            var result = new List<CategoryModel>();

            var parentCategory = categories.Where(x => x.Parent == null).ToList();
            var parentsIdList = categories.Select(x => x.ParentId).ToList();

            result = PopulateChildren(parentCategory, parentsIdList);

            return result;
        }

        private List<CategoryModel> PopulateChildren(List<Entities.Models.Category> categories, List<int?> parentsIdList)
        {
            var categoriesList = new List<CategoryModel>();
            if (categories.Any())
            {
                foreach (var category in categories)
                {
                    var categoryModel = new CategoryModel
                    {
                        Id = category.Id,
                        CategoryName = category.CategoryName,
                        ParentId = category.Parent?.Id,
                        Children = new List<CategoryModel>()
                    };

                    if (parentsIdList.Contains(categoryModel.Id))
                    {
                        categoryModel.Children = PopulateChildren(category.Children.ToList(), parentsIdList);
                    }                   


                    categoriesList.Add(categoryModel);
                }
            }
            return categoriesList;
        }
    }
}
