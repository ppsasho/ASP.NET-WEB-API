using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DTOs.Beverage
{
    public class CreateBeverageDto
    {
        [Required]
        [MinLength(2, ErrorMessage = "Please make sure the name is at least 2 characters long!")]
        public string Name { get; set; }
        [Required]
        [RegularExpression("^(Alcohol|Soft_Drink|Beer)$",
            ErrorMessage = "Invalid type. Please enter one of the following: Alcohol, Soft_Drink or Beer.")]
        public string Type { get; set; }
        [Required]
        [Range(1, int.MaxValue)]
        public int Quantity { get; set; }
        [Required]

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
    }
}
