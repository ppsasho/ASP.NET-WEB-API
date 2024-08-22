using System.ComponentModel.DataAnnotations;

namespace DTOs.Review
{
    public class CreateReviewDto
    {
        [Required]
        public string ReviewerName { get; set; }
        [Required]
        public string Comment { get; set; }
        [Required]
        public int Rating { get; set; }
        public string ImageUrl { get; set; }
        [Required]
        public int ProductId { get; set; }
    }
}
