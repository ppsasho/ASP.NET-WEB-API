using System.ComponentModel.DataAnnotations;

namespace DTOs.Category
{
    public class CreateCategoryDto
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [StringLength(150)]
        public string Description { get; set; }

    }
}
