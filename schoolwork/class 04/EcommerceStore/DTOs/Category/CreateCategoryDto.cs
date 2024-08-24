using System.ComponentModel.DataAnnotations;

namespace DTOs.Category
{
    public class CreateCategoryDto
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(150)]
        public string Description { get; set; }

    }
}
