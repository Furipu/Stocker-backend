using Contracts;
using Domain;

namespace Service.Quality
{
    public class SaveQualityOperation
    {
        private readonly IRepositoryWrapper _repo;
        public SaveQualityOperation(IRepositoryWrapper repo)
        {
            _repo = repo;
        }

        public int Execute(QualityModel quality)
        {

            var newQuality = new Entities.Models.Quality
            {
                QualityName = quality.QualityName
            };

            _repo.Quality.Create(newQuality);            
            _repo.Save();
            return newQuality.Id;

        }
    }
}
