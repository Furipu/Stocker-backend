using Contracts;
using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Quality
{
    public class GetAllQualityOperation
    {
        private readonly IRepositoryWrapper _repo;
        public GetAllQualityOperation(IRepositoryWrapper repo)
        {
            _repo = repo;
        }

        public List<QualityModel> Execute()
        {
            var qualities = _repo.Quality.FindAll();

            var result = new List<QualityModel>();

            foreach (var quality in qualities)
            {
                result.Add(new QualityModel
                {
                    Id = quality.Id,
                    QualityName = quality.QualityName
                });
            }

            return result;
        }
    }
}
