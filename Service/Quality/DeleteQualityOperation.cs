using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service.Quality
{
    public class DeleteQualityOperation
    {
        private readonly IRepositoryWrapper _repo;
        public DeleteQualityOperation(IRepositoryWrapper repo)
        {
            _repo = repo;
        }

        public void Execute(int id)
        {

            var quality = _repo.Quality.FindByCondition(x => x.Id == id).FirstOrDefault();
            _repo.Quality.Delete(quality);
            _repo.Save();
        }
    }
}
