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
        public static Review ToModel(this CreateReviewDto review, Review found)
        {
            found.ReviewerName = review.ReviewerName;
            found.Rating = review.Rating;
            found.ImageUrl = review.ImageUrl;
            found.Comment = review.Comment;
            found.ProductId = review.ProductId;
            return found;
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
