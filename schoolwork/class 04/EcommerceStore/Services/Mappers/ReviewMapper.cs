using DomainModels;
using DTOs.Review;

namespace Services.Mappers
{
    public static class ReviewMapper
    {
        public static Review ToModel(this CreateReviewDto review)
        {
            return new Review()
            {
                ReviewerName = review.ReviewerName,
                Rating = review.Rating,
                ImageUrl = review.ImageUrl,
                Comment = review.Comment,
                ProductId = review.ProductId,
            };
        }
        public static ReviewDto ToModel(this Review review)
        {
            return new ReviewDto()
            {
                ReviewerName = review.ReviewerName,
                Rating = review.Rating,
                Comment = review.Comment,
            };
        }
    }
}
