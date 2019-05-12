using Contracts;
using System.Linq;

namespace Service.Brand
{
    public class DeleteBrandOperation
    {
        private readonly IRepositoryWrapper _repo;
        public DeleteBrandOperation(IRepositoryWrapper repo)
        {
            _repo = repo;
        }

        public void Execute(int id)
        {   
            
            var brand = _repo.Brand.FindByCondition(x => x.Id == id).FirstOrDefault();
            var adress = _repo.Adress.FindByCondition(x => x.Id == brand.AdressId).FirstOrDefault();
            _repo.Adress.Delete(adress);
            _repo.Brand.Delete(brand);
            _repo.Save();
        }
    }
}
