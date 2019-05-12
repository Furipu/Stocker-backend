using Contracts;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service.Quality
{
    public class UpdateQualityOperation
    {
        private readonly IRepositoryWrapper _repo;

        public UpdateQualityOperation(IRepositoryWrapper repo)
        {
            _repo = repo;
        }

        public void Execute(QualityModel quality)
        {
            var qualityToUpdate = _repo.Quality.FindByCondition(x => x.Id == quality.Id).FirstOrDefault();
            qualityToUpdate.QualityName = quality.QualityName;
            _repo.Quality.Update(qualityToUpdate);
            _repo.Save();
        }
    }
}
