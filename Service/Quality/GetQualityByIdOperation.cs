using Contracts;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service.Quality
{
    public class GetQualityByIdOperation
    {
        private readonly IRepositoryWrapper _repo;
        public GetQualityByIdOperation(IRepositoryWrapper repo)
        {
            _repo = repo;
        }

        public QualityModel Execute(int id)
        {
            var quality = _repo.Quality.FindByCondition(qua => qua.Id == id).FirstOrDefault();

            return new QualityModel
            {
                Id = quality.Id,
                QualityName = quality.QualityName
            };
        }
    }
}
