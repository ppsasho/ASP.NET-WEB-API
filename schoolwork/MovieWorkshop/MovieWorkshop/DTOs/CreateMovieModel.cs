using DomainModels;
using System.ComponentModel.DataAnnotations;

namespace DTOs
{
    public class CreateMovieModel
    {
        [Required]
        public string Title { get; set; }
        [Required]
        [Range(1888, 2025, ErrorMessage = "Please make sure your year is in the range of 1888-2025!")]
        public int Year { get; set; }
        [Required]
        [RegularExpression("^(Drama|Thriller|Comedy|Fantasy|Romance|ScienceFiction|Adventure|Sports|Action|Western|Horror|Musical)$",
            ErrorMessage = "Invalid genre. Please enter one of the following: Drama, Thriller, Comedy, Fantasy, Romance, ScienceFiction, Adventure, Sports, Action, Western, Horror, Musical.")]
        public string Genre { get; set; }
        [MaxLength(250, 
            ErrorMessage = "Please make sure your description doesn't go over 250 characters!")]
        public string Description { get; set; }
    }
}
