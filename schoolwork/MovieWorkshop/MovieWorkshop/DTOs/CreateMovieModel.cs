using DomainModels;
using System.ComponentModel.DataAnnotations;

namespace DTOs
{
    public class CreateMovieModel : BaseEntity
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        public string Genre { get; set; }
        [MaxLength(250)]
        public string Description { get; set; }
    }
}
