using Contracts;
using Entities;
using Entities.Models;

namespace Repository
{
    public class AdressRepository : RepositoryBase<Adress>, IAdressRepository
    {
        public AdressRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}
