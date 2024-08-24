using DomainModels;
using DTOs.Review;

namespace Services.Interfaces
{
    public interface IReviewService
    {
        public bool Add(CreateReviewDto entity);

        public bool DeleteById(int id);

        public IEnumerable<ReviewDto> GetAll();

        public Review GetById(int id);

        public bool Update(CreateReviewDto entity, Review found);
    }
}
