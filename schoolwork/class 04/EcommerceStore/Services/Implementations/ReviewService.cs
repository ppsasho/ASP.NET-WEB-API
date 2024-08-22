using Data_Access.Interfaces;
using DomainModels;
using DTOs.Review;
using Services.Interfaces;
using Services.Mappers;

namespace Services.Implementations
{
    public class ReviewService : IReviewService
    {
        private readonly IReviewRepository _repository;
        public ReviewService(IReviewRepository repo)
        {
            _repository = repo;
        }
        public bool Add(CreateReviewDto entity) => entity != null && _repository.Add(entity.ToModel());
        public bool DeleteById(int id) => _repository.Any(id) && _repository.DeleteById(id);

        public List<ReviewDto> GetAll() => _repository.GetAll().Select(x => x.ToModel()).ToList();

        public Review GetById(int id) => _repository.GetById(id);

        public bool Update(CreateReviewDto entity) => entity != null && _repository.Update(entity.ToModel());
    }
}
