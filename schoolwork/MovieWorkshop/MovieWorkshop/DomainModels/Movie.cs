using DomainModels.Enums;
using System.ComponentModel.DataAnnotations;

namespace DomainModels
{
    public class Movie : BaseEntity
    {
        [Required]
        public string Title { get; set; }

        [MaxLength(250)]
        public string Description { get; set; }
        [Required]
        public Genre Genre { get; set; }
        [Required]
        public int Year { get; set; }
    }
}
