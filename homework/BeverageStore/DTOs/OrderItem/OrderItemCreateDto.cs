using System.ComponentModel.DataAnnotations;

namespace DTOs.OrderItem
{
    public class OrderItemCreateDto
    {
        [Required]
        public int BeverageId { get; set; }
        [Required]
        public int Quantity { get; set; }
    }
}
