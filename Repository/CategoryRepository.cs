using Contracts;
using Entities;
using Microsoft.EntityFrameworkCore;
using Entities.Models;
using System.Collections.Generic;
using System.Linq;

namespace Repository
{
    public class CategoryRepository : RepositoryBase<Category>, ICategoryRepository
    {
        private readonly RepositoryContext _repo;
        public CategoryRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
            _repo = repositoryContext;
        }

        public IQueryable<Category> GetAllWithInclude()
        {
            return _repo.Categories.Include(categorie => categorie.Children).AsNoTracking();
        }
    }
}
