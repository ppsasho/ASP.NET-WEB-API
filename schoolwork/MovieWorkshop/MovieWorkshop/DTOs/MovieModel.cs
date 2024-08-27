using System.ComponentModel.DataAnnotations;

namespace DTOs
{
    public class MovieModel
    {
        public string Title{ get; set; }
        public string  Description{ get; set; }
        [Range(1888, 2025, ErrorMessage = "Please make sure your year is in the range of 1888-2025!")]
        public int Year { get; set; }
        [RegularExpression("^(Drama|Thriller|Comedy|Fantasy|Romance|ScienceFiction|Adventure|Sports|Action|Western|Horror|Musical)$",
            ErrorMessage = "Invalid genre. Please enter one of the following: Drama, Thriller, Comedy, Fantasy, Romance, ScienceFiction, Adventure, Sports, Action, Western, Horror, Musical.\nGenres are case sensetive due to parsing strings into enumerators by their values.")]
        public string Genre { get; set; }
    }
}
