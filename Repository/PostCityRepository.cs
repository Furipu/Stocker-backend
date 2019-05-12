using Contracts;
using Entities;
using Entities.Models;

namespace Repository
{
    public class PostCityRepository : RepositoryBase<PostCity>, IPostCityRepository
    {
        public PostCityRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}
